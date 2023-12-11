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
        public int Count { get { return this.cars.Count; } }

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }


        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            { return "Car with that registration number, already exists!"; }

            if (Count == capacity) { return "Parking is full!"; }


            this.cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

        }

        public string RemoveCar(string RegistrationNumber) 

        {
            if (!cars.ContainsKey(RegistrationNumber)) { return "Car with that registration number, doesn't exist!"; }
            cars.Remove(RegistrationNumber);
            return $"Successfully removed {RegistrationNumber}";
        }

        public Car GetCar(string RegistrationNumber)
        {
            return cars[RegistrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers) 
        {
            foreach (string RegistrationNumber in RegistrationNumbers) 
            { 
            RemoveCar(RegistrationNumber);
            }
        }
    }
}
