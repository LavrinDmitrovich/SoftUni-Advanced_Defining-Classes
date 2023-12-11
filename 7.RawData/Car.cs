using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }  
        public Cargo Cargo { get; set; }    
        public Tires Tires { get; set; }

        public Car(string model, 
            int speed,
            int power,
            int weight,
            string type,
            double pressure1,
            int age1,
            double pressure2,
            int age2,
            double pressure3,
            int age3,
            double pressure4,
            int age4
            )
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.Tires = new Tires(pressure1, age1, pressure2, age2, pressure3, age3, pressure4, age4);
        }
    }
}
