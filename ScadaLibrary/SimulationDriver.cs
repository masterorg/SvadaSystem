using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadaLibrary
{
  public static  class SimulationDriver
    {
        static double amplitude = 100;

        public static double Sine()
        {

            return amplitude * Math.Sin((double)DateTime.Now.Second / 60 * Math.PI);

        }

        public static double Cosine()
        {

            return amplitude * Math.Cos((double)DateTime.Now.Second / 60 * Math.PI);

        }

        public static double Ramp()
        {

            return amplitude * DateTime.Now.Second / 60;

        }
    }
}
