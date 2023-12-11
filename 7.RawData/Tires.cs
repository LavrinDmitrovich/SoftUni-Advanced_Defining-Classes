using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
        public double Tyre1Pressure { get; set; }
        public int Tyre1Age { get; set; }

        public double Tyre2Pressure { get; set; }
        public int Tyre2Age { get; set; }

        public double Tyre3Pressure { get; set; }
        public int Tyre3Age { get; set; }

        public double Tyre4Pressure { get; set; }
        public int Tyre4Age { get; set; }

        public Tires(double tyre1Pressure, int tyre1Age, double tyre2Pressure, int tyre2Age, double tyre3Pressure, int tyre3Age, double tyre4Pressure, int tyre4Age)
        {
            Tyre1Pressure = tyre1Pressure;
            Tyre1Age = tyre1Age;
            Tyre2Pressure = tyre2Pressure;
            Tyre2Age = tyre2Age;
            Tyre3Pressure = tyre3Pressure;
            Tyre3Age = tyre3Age;
            Tyre4Pressure = tyre4Pressure;
            Tyre4Age = tyre4Age;
        }   

    }
}
