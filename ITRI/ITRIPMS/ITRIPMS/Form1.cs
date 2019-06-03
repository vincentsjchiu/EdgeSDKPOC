using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using PMSdignoise;
using System.IO;
namespace ITRIPMS
{
    public partial class Form1 : MetroForm
    {
        Form2 myForm2;
        Thread thdreveice;
        pmsparameter config = new pmsparameter();
        int receive = 0;
        Random r = new Random();
        
        public class pmsparameter
        {
            public double[] allrawdata;
            public double[] subrawdata;
            public double[] fftResult;
            public const int _diagnosisCount = 17;
            public double[] _result = new double[_diagnosisCount];
            public double nudThreshold;//全部的閥值 80以上為有問題
            public double[] Test = new double[17];
            public int samplelength;
            public double samplerate;
            public double startF;
            public double EndF;
            public double Rpm;
            public double Grms;
            public double EHI;
            public double Vrms;
            public double[] result;
            public double[] convResult;
            public double[] envelopeResult;
            public IntPtr receiveRawdata;
            public string strReceiveRawdata;
            public JObject rawdata;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButtonSetting_Click(object sender, EventArgs e)
        {
            myForm2 = new Form2();
            myForm2.ShowDialog();

        }
        private void InitialParameter()
        {
            JObject readjson;
            string configFilePath;
            configFilePath = "C:\\ITRIPMS\\configuration.json";
            readjson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(configFilePath));
            config.samplerate = Convert.ToInt32(readjson["SampleRate"]);
            config.samplelength = Convert.ToInt32(readjson["SampleLength"]);
            config.allrawdata = new double[Convert.ToInt32(config.samplerate)];
            config.subrawdata = new double[config.samplelength];
            config.fftResult = new double[config.samplelength];
            config.nudThreshold = Convert.ToDouble(readjson["Threshold"]);//全部的閥值 80以上為有問題
            config.startF = Convert.ToDouble(readjson["StartFrequency"]);
            config.EndF = Convert.ToDouble(readjson["EndFrequency"]);
            config.Rpm = Convert.ToDouble(readjson["RPM"]);
            config.envelopeResult = new double[config.samplelength];
            config.convResult = new double[config.samplelength];
        }


        private void Reveice()
        {
            while (true)
            {
                //receive data
                try
                {
                    //Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Start Receive Rawdata...");
                    config.receiveRawdata = Edge.CSharp.ReceiveData("rawdata");
                    config.strReceiveRawdata = Marshal.PtrToStringAnsi(config.receiveRawdata);
                    Marshal.Release(config.receiveRawdata);
                    //Console.WriteLine(DateTime.Now);
                    config.rawdata = (JObject)JsonConvert.DeserializeObject(config.strReceiveRawdata);
                    config.allrawdata = JsonConvert.DeserializeObject<double[]>(config.rawdata["rawdata"].ToString());
                    //Console.WriteLine("Equipment ID is"+ rawdata["rawequipmentId"].ToString());
                    /*for (int i = 0; i < config.allrawdata.Length; i++)
                    {
                        config.allrawdata[i] = (double)(r.Next(0, 100)) / 10000;
                    }*/
                    
                    Array.Copy(config.allrawdata, config.subrawdata, config.samplelength);
                    config.Vrms = PMS.forward2(config.subrawdata, config.samplelength, config.fftResult, config.samplelength, config.samplerate);//vel 10816-1 group1
                    config.Grms = PMS.grms(config.subrawdata, config.samplelength);//all
                    config.EHI = PMS.getCv(config.subrawdata, config.samplelength, config.Vrms);                    
                    Console.WriteLine("Vrms = " + config.Vrms.ToString());
                    Console.WriteLine("Grms = " + config.Grms.ToString());
                    Console.WriteLine("EHI = " + config.EHI.ToString());
                    config.result = diagnosisDllimport(config.subrawdata);
                    
                    this.Invoke((MethodInvoker)delegate
                    {
                        metroTextBoxEHI.Text = config.EHI.ToString();
                        metroTextBoxUnbalanceIndex.Text = config.result[0].ToString();
                        metroTextBoxBentshaftIndex.Text = config.result[1].ToString();
                        metroTextBoxMisalignmentIndex.Text = config.result[2].ToString();
                        metroTextBoxLoosenessIndex.Text = config.result[3].ToString();
                    });
                    Thread.Sleep(1000);
                    //receive = receive + 1;
                    Console.WriteLine(DateTime.Now);
                    Edge.CSharp.AddData("equipmentId", "Compressor05");
                    Edge.CSharp.AddData("CH0_EHI", config.EHI);
                    Console.WriteLine("Sent itripms...");
                    Edge.CSharp.SentData("itripms");
                    //Console.WriteLine(DateTime.Now);
                    //richTextBoxReceive.Text = "Receive Rawdata..."+receive.ToString();


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void metroButtonStart_Click(object sender, EventArgs e)
        {
            InitialParameter();
            thdreveice = new Thread(Reveice);
            thdreveice.Start();

        }
        private double[] diagnosisDllimport(double[] channel_data)
        {

            PMS.setFa(config.Rpm / 60);
            PMS.setBallBearingParams(0, 0, 0, 0, 0, 0, 0);
            PMS.setNRotors(0);
            PMS.setGearParams(0, 0);
            PMS.executeWaveletEnvelope(config.samplerate, config.startF, config.EndF, 0.007, .0075, channel_data, config.samplelength, config.convResult);//0.007 0.0075固定參數不變
            PMS.forward2(config.convResult, config.convResult.Length, config.envelopeResult, config.envelopeResult.Length, config.samplerate);
            PMS.findFeatures(config.fftResult, config.envelopeResult, config.samplelength, config.samplerate);
            PMS.diagnose1(config._result, config.nudThreshold / 100.0);
            for (int i = 0; i < config._result.Length; i++)
            { 
                config._result[i] = Math.Round(config._result[i], 5);
            }

            return config._result;

        }

        private void metroButtonStop_Click(object sender, EventArgs e)
        {
            if (thdreveice != null)
            {
                if (thdreveice.IsAlive)
                {
                    if (false == thdreveice.Join(200))
                    {
                        thdreveice.Abort();
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thdreveice != null)
            {
                if (thdreveice.IsAlive)
                {
                    if (false == thdreveice.Join(200))
                    {
                        thdreveice.Abort();
                    }
                }
            }
        }
    }
}
