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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace ITRIPMS
{
    public partial class Form2 : MetroForm
    {
        public double threshold = 0;
        public double SampleRate = 0;
        public double SampleLength = 0;
        public double startF = 0;
        public double EndF = 0;
        public double Rpm = 0;

        public Form2()
        {
            InitializeComponent();
            ReadConfiguartion();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            WriteConfiguration();
            /*threshold = Convert.ToDouble(numericUpDownThreshold.Value);
            SampleRate = Convert.ToDouble(numericUpDownSampleRate.Value);
            SampleLength = Convert.ToDouble(numericUpDownSampleLength.Value);
            startF = Convert.ToDouble(numericUpDownStartFrequency.Value);
            EndF = Convert.ToDouble(numericUpDownEndFrequency.Value);
            Rpm = Convert.ToDouble(numericUpDownRPM.Value);*/
        }
        private void WriteConfiguration()
        {
            JObject writedjson;
            string configFilePath;
            configFilePath = "C:\\ITRIPMS\\configuration.json";
            writedjson = new JObject();
            writedjson["Threshold"] = numericUpDownThreshold.Value;
            writedjson["SampleRate"] = numericUpDownSampleRate.Value;
            writedjson["SampleLength"] = numericUpDownSampleLength.Value;
            writedjson["StartFrequency"] = numericUpDownStartFrequency.Value;
            writedjson["EndFrequency"] = numericUpDownEndFrequency.Value;
            writedjson["RPM"] = numericUpDownRPM.Value;
            File.WriteAllText(configFilePath, writedjson.ToString());
        }
        private void ReadConfiguartion()
        {
            JObject readjson;
            string configFilePath;
            configFilePath = "C:\\ITRIPMS\\configuration.json";
            readjson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(configFilePath));
            numericUpDownThreshold.Value = Convert.ToDecimal(readjson["Threshold"]);
            numericUpDownSampleRate.Value = Convert.ToDecimal(readjson["SampleRate"]);
            numericUpDownSampleLength.Value = Convert.ToDecimal(readjson["SampleLength"]);
            numericUpDownStartFrequency.Value = Convert.ToDecimal(readjson["StartFrequency"]);
            numericUpDownEndFrequency.Value = Convert.ToDecimal(readjson["EndFrequency"]);
            numericUpDownRPM.Value = Convert.ToDecimal(readjson["RPM"]);

        }
    }
}
