using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ScadaLibrary;
using System.Threading;

namespace SCADACore
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
   public class Core:IDatabaseManager,IAlarmDisplay,ITrading,IDisposable
    {

        private Dictionary<String, Thread> threads;
        

        public void addDI(Digitalinput el)
        {
            throw new NotImplementedException();
        }

        public void addDO(DigitalOutput el)
        {
            throw new NotImplementedException();
        }

        public void addAI(AnalogInput el)
        {
            throw new NotImplementedException();
        }

        public void addAO(AnalogOutput el)
        {
            throw new NotImplementedException();
        }

        public void removeElement(string id)
        {
            throw new NotImplementedException();
        }

        public void turnOnScan(string id)
        {
            throw new NotImplementedException();
        }

        public void turnOffScan(string id)
        {
            throw new NotImplementedException();
        }

        public void turnOnAuto(string id)
        {
            throw new NotImplementedException();
        }

        public void turnOnManual(string id)
        {
            throw new NotImplementedException();
        }



        public string writeAlarms()
        {
            throw new NotImplementedException();
        }

        public string writeData()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Console.WriteLine("Shutting down the server");
        }
    }
}
