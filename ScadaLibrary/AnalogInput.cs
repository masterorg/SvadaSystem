using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [DataContract]
  public  class AnalogInput
    {
        [DataMember]
        private string tagName;
        [DataMember]
        private string description;
        [DataMember]
        private SimulationDriver driver;
        [DataMember]
        private string ioAddress;
        [DataMember]
        private int scanTime;
        /*******FALE ALARMI*****/
        [DataMember]
        private bool onOfScan;
        [DataMember]
        private bool autoOrManual;
        [DataMember]
        private double lowLimit;
        [DataMember]
        private double highLimit;
      /**********FALE UNITS***********/

        public double HighLimit
        {
            get { return highLimit; }
            set { highLimit = value; }
        }


        public SimulationDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        public double LowLimit
        {
            get { return lowLimit; }
            set { lowLimit = value; }
        }


        public bool AutoOrManual
        {
            get { return autoOrManual; }
            set { autoOrManual = value; }
        }

        public bool OnOfScan
        {
            get { return onOfScan; }
            set { onOfScan = value; }
        }


        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }

        public string IoAddress
        {
            get { return ioAddress; }
            set { ioAddress = value; }
        }

        

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }
    }
}
