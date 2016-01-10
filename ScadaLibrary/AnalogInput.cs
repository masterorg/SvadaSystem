using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
  public  class AnalogInput
    {
        private string tagName;
        private string description;
        private string driver;
        private string ioAddress;
        private int scanTime;
        /*******FALE ALARMI*****/
        private bool onOfScan;
        private bool autoOrManual;
        private double lowLimit;
        private double highLimit;
      /**********FALE UNITS***********/

        public double HighLimit
        {
            get { return highLimit; }
            set { highLimit = value; }
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

        public string Driver
        {
            get { return driver; }
            set { driver = value; }
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
