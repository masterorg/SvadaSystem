using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
   public interface IDatabaseManager
    {
       void addElement(Object el);
       void removeElement(Object el);
       void turnOnScan(Object el);
       void turnOffScan(Object el);
       void turnOnAuto(Object el);
       void turnOnManual(Object el);

    }
}
