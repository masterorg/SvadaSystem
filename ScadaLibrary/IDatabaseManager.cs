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
       void removeElement(String id);
        [OperationContract]
       void turnOnScan(String id);
        [OperationContract]
       void turnOffScan(String id);
        [OperationContract]
       void turnOnAuto(String id);
        [OperationContract]
       void turnOnManual(String id);

    }
}
