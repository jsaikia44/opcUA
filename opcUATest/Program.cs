using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Opc.UaFx;
using Opc.UaFx.Client;

namespace opcUATest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new OpcClient("opc.tcp://10.141.7.69:62640/IntegrationObjects/ServerSimulator");
                client.Connect();

               
                while (true)
                {
                    OpcValue val = client.ReadNode("ns=2;s=Tag19");    
                    Console.WriteLine("Value: {0}, Status: {1}", val, val.Status.ToString());
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
