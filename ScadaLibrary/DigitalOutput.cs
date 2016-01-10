using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
   public class DigitalOutput
    {

        private string tagname;
        private string description;
        private string driver;
        private string ioAdress;
        private double initialValue;

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }

        public string IoAdress
        {
            get { return ioAdress; }
            set { ioAdress = value; }
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

        public string Tagname
        {
            get { return tagname; }
            set { tagname = value; }
        }

        public DigitalOutput() { }
    }
}
