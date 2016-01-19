using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace ScadaLibrary
{
    [DataContract]
   public class DigitalOutput
    {
        [DataMember]
        private string tagname;
        [DataMember]
        private string description;
        [DataMember]
        private SimulationDriver driver;
        [DataMember]
        private string ioAdress;
        [DataMember]
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

        public SimulationDriver Driver
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
