using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [ServiceContract]
    interface IAlarmDisplay
    {

        [OperationContract]
        void writeAlarms();
    }
}
