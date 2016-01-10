using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
   public class Digitalinput
    {
        private String tagName;

        public String TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }
        private String descrition;

        public String Descrition
        {
            get { return descrition; }
            set { descrition = value; }
        }

        private String driver;

        public String Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        private String ioAdress;

        public String IoAdress
        {
            get { return ioAdress; }
            set { ioAdress = value; }
        }
        private int scanTime;

        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }

       /***************FALE ALARMI*************/
        private bool onOfScan;

        public bool OnOfScan
        {
            get { return onOfScan; }
            set { onOfScan = value; }
        }
        private bool autoOrManual;

        public bool AutoOrManual
        {
            get { return autoOrManual; }
            set { autoOrManual = value; }
        }

        public Digitalinput() { }  

    }
}
