using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ScadaLibrary;

namespace SCADACore
{
   internal sealed class Program
    {

        private static Core service;
        static ServiceHost sv;

        public Program()
        {
            Console.WriteLine("WCFServer kreiran.");
        }
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
            Stop();
        }

        public static void Start()
        {
            service = new Core();
            sv = new ServiceHost(service);

            Uri address1 = new Uri("http://localhost:8000/IAlarmDisplay");
            Uri address2 = new Uri("net.tcp://localhost:4000/IDatabaseManager");
            Uri address3 = new Uri("http://localhost:9000/ITrading");

            BasicHttpBinding binding1 = new BasicHttpBinding();
            NetTcpBinding binding2 = new NetTcpBinding();
            BasicHttpBinding binding3 = new BasicHttpBinding();

            sv.AddServiceEndpoint(typeof(IAlarmDisplay), binding1, address1);
            sv.AddServiceEndpoint(typeof(IDatabaseManager), binding2, address2);
            sv.AddServiceEndpoint(typeof(ITrading), binding3, address3);


            Console.WriteLine("WCFServer kreiran.");
            sv.Open();


        }
        public static void Stop()
        {

            sv.Close();
        }
    }
}
