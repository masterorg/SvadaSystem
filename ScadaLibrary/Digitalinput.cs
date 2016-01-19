using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [DataContract]
   public class Digitalinput
    {
        [DataMember]
        private String tagName;
        [DataMember]
        private bool autoOrManual;
        [DataMember]
        private String descrition;
        [DataMember]
        private SimulationDriver driver;
        [DataMember]
        private String ioAdress;
        [DataMember]
        private int scanTime;
        [DataMember]
        private bool onOfScan;

        public String TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }
       

        public String Descrition
        {
            get { return descrition; }
            set { descrition = value; }
        }
       

        public SimulationDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        

        public String IoAdress
        {
            get { return ioAdress; }
            set { ioAdress = value; }
        }
        

        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }

       /***************FALE ALARMI*************/

        

        public bool OnOfScan
        {
            get { return onOfScan; }
            set { onOfScan = value; }
        }
        

        public bool AutoOrManual
        {
            get { return autoOrManual; }
            set { autoOrManual = value; }
        }

        public Digitalinput() { }  

    }
}
