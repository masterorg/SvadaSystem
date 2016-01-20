using ScadaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(2000);


            Uri address = new Uri("net.tcp://localhost:4000/IDatabaseManager");
            NetTcpBinding binding = new NetTcpBinding();

            ChannelFactory<IDatabaseManager> factory = new ChannelFactory<IDatabaseManager>(binding, new EndpointAddress(address));

            IDatabaseManager proxy = factory.CreateChannel();

            Console.WriteLine("Database Manager started");
            Digitalinput i = new Digitalinput();

            i.AutoOrManual = true;
            i.Descrition = "Pumpa";
            i.Driver = new SimulationDriver();
            i.TagName = "di1";

            Console.WriteLine("Adding DI tag");
            proxy.addDI(i);

            proxy.removeElement("bb");
            Console.WriteLine("Turn on scan");
            proxy.turnOnScan("di1");


            Console.ReadLine();
        }
    }
}
