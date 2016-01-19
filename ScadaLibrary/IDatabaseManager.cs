using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
    [ServiceContract]
   public interface IDatabaseManager
    {
        [OperationContract]
       void addDI(Digitalinput el);
        [OperationContract]
       void addDO(DigitalOutput el);
        [OperationContract]
       void addAI(AnalogInput el);
        [OperationContract]
       void addAO(AnalogOutput el);
        [OperationContract]
       void removeElement(Object el);
        [OperationContract]
       void turnOnScan(Object el);
        [OperationContract]
       void turnOffScan(Object el);
        [OperationContract]
       void turnOnAuto(Object el);
        [OperationContract]
       void turnOnManual(Object el);

    }
}
