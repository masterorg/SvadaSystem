using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [DataContract]
   public class AnalogOutput
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
        private double initialValue;
        [DataMember]
        private double lowLimit;
        [DataMember]
        private double highLimit;

       /*******FALE UNITS**********/

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

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }

        public string IoAddress
        {
            get { return ioAddress; }
            set { ioAddress = value; }
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

        public string TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }

    }
}
