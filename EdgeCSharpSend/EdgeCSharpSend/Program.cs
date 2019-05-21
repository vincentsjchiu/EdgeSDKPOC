using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeCSharpSend
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                while (true)
                {
                    try
                    {
                        //rawdata simulate
                        double[] rawdata = new double[8192];
                        Random r = new Random();
                        for (int i = 0; i < rawdata.Length; i++)
                        {
                            rawdata[i] = (double)(r.Next(0, 100)) / 10000;
                        }

                        //Create message
                        Edge.CSharp.AddData("temperature", 3.2);
                        Edge.CSharp.AddData("grms", 1.5);
                        Edge.CSharp.AddData("equipmentId", "Compressor05");
                        Edge.CSharp.AddData("CH0_OA", 0.01);
                        //Edge.CSharp.AddData("rawdata", rawdata, rawdata.Length);

                        //Sent Message
                        Console.WriteLine("Sent Tags...");
                        Edge.CSharp.SentData("tags");
                        
                        System.Threading.Thread.Sleep(2000);

                        Edge.CSharp.AddData("rawdata", rawdata, rawdata.Length);
                        Console.WriteLine("Sent Rawdata...");
                        Edge.CSharp.SentData("rawdata");
                        
                        System.Threading.Thread.Sleep(6000);
                        
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
        }
    }
}
