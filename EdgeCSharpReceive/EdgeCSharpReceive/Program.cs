using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using Newtonsoft.Json;
using adlinkClient;

namespace EdgeCSharpReceive
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client client = new Client();
                string deviceId = string.Empty;

                /*Initial DataConnect Pro Connection*/

                //int initialSuccess = client.Initial(0, "test19", "garage", "VCM", out deviceId);

                //if (initialSuccess == false)
                //{
                //    Console.WriteLine("DataConnectPro connect Fail, press any key to exit");
                //    Console.ReadKey();

                //    return;
                //}

                while (true)
                {
                    //receive data
                    try
                    {
                        Console.WriteLine("Start Receive Tags...");

                        IntPtr receive = Edge.CSharp.ReceiveData("tags");
                        string strReceive = Marshal.PtrToStringAnsi(receive);
                        //Console.WriteLine("Received " + strReceive);

                        Marshal.Release(receive);
                        dynamic tags = JsonConvert.DeserializeObject(strReceive);
                        Console.WriteLine("CH0_OA = " + tags["CH0_OA"]);
                        
                        //sent to DataConnectPro
                        //client.SendData(strReceive);

                        System.Threading.Thread.Sleep(1000);

                        Console.WriteLine("Start Receive Rawdata...");

                        IntPtr receiveRawdata = Edge.CSharp.ReceiveData("rawdata");
                        string strReceiveRawdata = Marshal.PtrToStringAnsi(receiveRawdata);

                        Marshal.Release(receiveRawdata);
                        dynamic rawdata = JsonConvert.DeserializeObject(strReceiveRawdata);
                        Console.WriteLine("CH0_OA = " + rawdata["CH0_OA"]);
                        Console.WriteLine("rawdata = " + rawdata["rawdata"]);


                        System.Threading.Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
