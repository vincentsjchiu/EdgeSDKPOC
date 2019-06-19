using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using adlinkClient;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using MetroFramework.Forms;
using System.Threading;
using System.Runtime.InteropServices;
namespace DataConnectProClientSample
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int initialSuccess=0 ;
        int sendDataSuccess =0;
        int getEquipmentIDSuccess=0 ;
        ushort cardNumber = 0;//MCM-100 is always 0, if you connect to USB-2405,it will depends on the hardware configuration
        string username;
        string password;
        string messageName = "VCM";//Tell the DataConnectPro those data come from which edge software 
        int companyId;
        string[] Equipment;
        string equipmentid;
        Client client = new Client();
        string deviceId;
        JObject topicName;
        Thread thdreveice;
        dynamic tags;
        private void Form1_Load(object sender, EventArgs e)
        {
            Edge.CSharp.Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //messageName = this.textBoxMessageName.Text;
            username = this.textBoxUsername.Text;
            password = this.textBoxPassword.Text;
            initialSuccess = client.Initial(cardNumber, username, password, messageName, out deviceId);
            this.textBoxDeviceID.Text = deviceId;
            if (initialSuccess == 0)
            {
                MessageBox.Show("Initial Success");
                client.MessageReached += Client_MessageReached;
                
            }
            else
            {
                MessageBox.Show("Initial Fail");
            }
            
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.comboBox1.Items.Clear();
            getEquipmentIDSuccess = client.GetEquipmentID(out Equipment);
            if (getEquipmentIDSuccess == 0)
            {
                comboBox1.Items.AddRange(Equipment);
            }
            else
            {
                MessageBox.Show("Get EquipmentID Fail");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topicName = new JObject();
            topicName["equipmentId"] = equipmentid;
            topicName["equipmentRunStatus"] = 1;
            topicName["MessageName"] = messageName;
            topicName["CH0_OA"] = (double)randomNumber(1, 100);
            topicName["CH0_OA_I"] = "10 Hz to 1000 Hz";
            topicName["CH1_OA"] = (double)randomNumber(2, 100);
            topicName["CH1_OA_I"] = "10 Hz to 1000 Hz";
            topicName["CH2_OA"] = (double)randomNumber(3, 100);
            topicName["CH2_OA_I"] = "10 Hz to 1000 Hz";
            topicName["CH3_OA"] = (double)randomNumber(4, 100);
            topicName["CH3_OA_I"] = "10 Hz to 1000 Hz";
            //Task.Run(() => sendDataSuccess = client.SendData(topicName.ToString()));
            sendDataSuccess = client.SendData(topicName.ToString());
            if (sendDataSuccess != 0)
            {
                MessageBox.Show("SendData Fail");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentid = Convert.ToString(comboBox1.SelectedItem);
        }
        private void Client_MessageReached(object sender, ReceiveEventArgs e)
        {
            richTextBoxMessagefromDataConnectPro.Text = e.Msg;
            //Console.WriteLine(e.Msg.ToString());
        }
        private int randomNumber(int boundMin, int boundMax)
        {

            Random Rnd = new Random(); //加入Random，產生的數字不會重覆

            int x = Rnd.Next(boundMin, boundMax);

            return x;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            username = this.metroTextBoxUsername.Text;
            password = this.metroTextBoxPassword.Text;
            initialSuccess = client.Initial(cardNumber, username, password, messageName, out deviceId);          
            this.textBoxDeviceID.Text = deviceId;
            if (initialSuccess == 0)
            {
                MessageBox.Show("Initial Success");
                client.MessageReached += Client_MessageReached;
                
                thdreveice = new Thread(Reveice);
                thdreveice.Start();

            }
            else
            {
                MessageBox.Show("Initial Fail");
            }
           
        }
        private void Reveice()
        {
            while (true)
            {
                try
                {
                    topicName = new JObject();
                    
                    //Console.WriteLine("Start Receive Tags...");                    
                    IntPtr receive = Edge.CSharp.ReceiveDataEx("tags");
                    if (receive != IntPtr.Zero) //Ensure return result
                    {
                        string strReceive = Marshal.PtrToStringAnsi(receive);
                        Marshal.Release(receive);
                        tags = JsonConvert.DeserializeObject(strReceive);
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxMessagefromDataConnectPro.Text = DateTime.Now+" CH0_OA = " + tags["CH0_OA"];
                            //richTextBoxMessagefromDataConnectPro.Text = "Equipment ID is " + tags["equipmentId"] + "\n";
                            //richTextBoxMessagefromDataConnectPro.Text = "CH0_OA = " + tags["CH0_OA"] + "\n";

                        });
                    }
                    System.Threading.Thread.Sleep(10);
                    IntPtr receivepms = Edge.CSharp.ReceiveDataEx("itripms");
                    if (receivepms != IntPtr.Zero) //Ensure return result
                    {
                        string strReceivepms = Marshal.PtrToStringAnsi(receivepms);
                        Marshal.Release(receivepms);
                        dynamic tagspms = JsonConvert.DeserializeObject(strReceivepms);
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxMessagefromDataConnectPro.Text = DateTime.Now + " CH0_EHI = " + tagspms["CH0_EHI"];
                            //richTextBoxMessagefromDataConnectPro.Text = "Equipment ID is " + tagspms["equipmentId"] + "\n";
                            //richTextBoxMessagefromDataConnectPro.Text = "CH0_EHI = " + tagspms["CH0_EHI"] + "\n";

                        });
                        topicName["equipmentId"] = tagspms["equipmentId"];
                        topicName["equipmentRunStatus"] = 1;
                        topicName["MessageName"] = "VCM";
                        topicName["CH0_OA"] = tags["CH0_OA"];
                        topicName["CH0_EHI"] = tagspms["CH0_EHI"];
                        topicName["CH0_Unbalance"] = tagspms["CH0_Unbalance"];
                        topicName["CH0_Misalignment"] = tagspms["CH0_Misalignment"];
                        topicName["CH0_BentShaft"] = tagspms["CH0_BentShaft"];
                        topicName["CH0_Looseness"] = tagspms["CH0_Looseness"];
                        sendDataSuccess = client.SendData(topicName.ToString());
                        if (sendDataSuccess != 0)
                        {
                            MessageBox.Show("SendData Fail");
                        }
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxMessagefromDataConnectPro.Text = DateTime.Now + " Send data to DCP Done";
                            //richTextBoxMessagefromDataConnectPro.Text = "Send data to DCP Done.." + "\n";
                        });
                    }
                        System.Threading.Thread.Sleep(100);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thdreveice != null)
            {
                
                if (thdreveice.IsAlive)
                {
                    if (false == thdreveice.Join(200))
                    {
                        thdreveice.Abort();
                        Edge.CSharp.Deinit();
                    }
                }
            }
        }
    }
}   
