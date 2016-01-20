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

        private Dictionary<String, Thread> threads = new Dictionary<String,Thread>();
        private Dictionary<String, Object> tags = new Dictionary<String,Object>();


        

        public void addDI(Digitalinput el)
        {
            if (el != null && !tags.ContainsKey(el.TagName))
            {
                lock (tags)
                {
                    tags.Add(el.TagName,el);
                }
                Console.WriteLine("DI Tag :" +el.TagName+" is added");
            }
        }

        public void addDO(DigitalOutput el)
        {
            if (el != null && !tags.ContainsKey(el.Tagname))
            {
                lock (tags)
                {
                    tags.Add(el.Tagname, el);
                }
                Console.WriteLine("DO Tag :" + el.Tagname + " is added");
            }
        }

        public void addAI(AnalogInput el)
        {
            if (el != null && !tags.ContainsKey(el.TagName))
            {
                lock (tags)
                {
                    tags.Add(el.TagName, el);
                }
                Console.WriteLine("AI Tag :" + el.TagName + " is added");
            }
        }

        public void addAO(AnalogOutput el)
        {
            if (el != null && !tags.ContainsKey(el.TagName))
            {
                lock (tags)
                {
                    tags.Add(el.TagName, el);
                }
                Console.WriteLine("AO Tag :" + el.TagName + " is added");
            }
        }

        public void removeElement(string id)
        {
            if (tags.ContainsKey(id))
            { 
                lock(tags)
                {
                    tags.Remove(id);
                    
                }
                Console.WriteLine(" Tag with key :" + id + " is removed");
            }
            else
                Console.WriteLine(" Tag with key :" + id + " doesnt exists");
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
