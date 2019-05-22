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
using System.Runtime.InteropServices;
using PMSdignoise;
namespace ITRIPMS
{
    public partial class Form1 : MetroForm
    {
        Form2 myForm2;
        Thread thdreveice;
        public double[] allrawdata = new double[25600];
        public double[] subrawdata = new double[16384];
        public double[] fftResult = new double[16384];
        const int _diagnosisCount = 17;
        public double[] _result = new double[_diagnosisCount];
        public double nudThreshold = 10;//全部的閥值 80以上為有問題
        public double[] Test = new double[17];
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButtonSetting_Click(object sender, EventArgs e)
        {
            myForm2 = new Form2();
            myForm2.ShowDialog();

        }
        private void Reveice()
        {
            while (true)
            {
                //receive data
                try
                {
                    double Grms;
                    double EHI;
                    double Vrms;
                    Console.WriteLine("Start Receive Rawdata...");
                    IntPtr receiveRawdata = Edge.CSharp.ReceiveData("rawdata");                
                    string strReceiveRawdata = Marshal.PtrToStringAnsi(receiveRawdata);
                    Marshal.Release(receiveRawdata);
                    dynamic rawdata = JsonConvert.DeserializeObject(strReceiveRawdata);
                    allrawdata = JsonConvert.DeserializeObject<double[]>(rawdata["rawdata"].ToString());
                    Array.Copy(allrawdata, subrawdata, 16384);
                    Vrms = PMS.forward2(subrawdata, 16384, fftResult, 16384, 25600);//vel 10816-1 group1
                    Grms = PMS.grms(subrawdata, 16384);//all
                    EHI = PMS.getCv(subrawdata, 16384, Vrms);
                    Console.WriteLine("Vrms = " + Vrms.ToString());
                    Console.WriteLine("Grms = " + Grms.ToString());
                    Console.WriteLine("EHI = " + EHI.ToString());
                    Test = diagnosisDllimport(subrawdata);
                    /*for (int i = 0; i < Test.Length; i++)
                    {
                        Console.WriteLine(Test[i].ToString());
                    }*/
                    this.Invoke((MethodInvoker)delegate
                    {
                        metroTextBoxEHI.Text = EHI.ToString();
                        metroTextBoxUnbalanceIndex.Text = Test[0].ToString();
                        metroTextBoxBentshaftIndex.Text = Test[1].ToString();
                        metroTextBoxMisalignmentIndex.Text = Test[2].ToString();
                        metroTextBoxLoosenessIndex.Text = Test[3].ToString();
                    });
                    //Console.WriteLine("CH0_OA = " + rawdata["CH0_OA"]);
                    //Console.WriteLine("rawdata = " + rawdata["rawdata"]);


                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void metroButtonStart_Click(object sender, EventArgs e)
        {
            thdreveice = new Thread(Reveice);
            thdreveice.Start();

        }
        private double[] diagnosisDllimport(double[] channel_data)
        {
          
            double sampleRate = 25600;
            int sampleLength = 16384;
            PMS.setFa(1700 / 60);
            
            /*PMS.setBallBearingParams(0, 0, 0, 0, 0, 0, 0);
            PMS.setNRotors(0);
            
            PMS.setGearParams(0, 0);*/
            int l = 16384;
            double[] convResult = new double[l];
            double[] envelopeResult = new double[16384];
            //double[] fftResult2 = new double[16384];
            //double vrms = PMS.forward2(channel_data, l, fftResult2, sampleLength, sampleRate);
            PMS.executeWaveletEnvelope(sampleRate, 10, 5000, 0.007, .0075, channel_data, sampleLength, convResult);//0.007 0.0075固定參數不變
            PMS.forward2(convResult, convResult.Length, envelopeResult, envelopeResult.Length, sampleRate);
            PMS.findFeatures(fftResult, envelopeResult, sampleLength, sampleRate);
            PMS.diagnose1(_result, nudThreshold / 100.0);
            for (int i = 0; i < _result.Length; i++)
                _result[i] = Math.Round(_result[i], 5);

            return _result;

        }
    }
}
