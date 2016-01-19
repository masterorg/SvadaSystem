using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [DataContract]
   public class Alarm
    {
        [DataMember]
        private String message;

        public Alarm() { }

        public String Message
        {
            get { return message; }
            set { message = value; }
        }

        
       

       
    }
}
