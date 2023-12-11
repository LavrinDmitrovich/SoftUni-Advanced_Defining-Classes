using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        public Dictionary<string, Car> cars;
        private int capacity;
        public int carsCount { get { return this.cars.Count; } }

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }

        
        public string AddCar(Car car) 
        {
            if (cars.ContainsKey(car.RegistrationNumber))
                Console.WriteLine("Car with that registration number, already exists!");

            if (carsCount == capacity)
                Console.WriteLine("Parking is full!");

            
            cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

        }
    }
}
