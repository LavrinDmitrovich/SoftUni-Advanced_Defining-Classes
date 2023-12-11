using System.Security.Cryptography.X509Certificates;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < qty; i++)
            {
                string[] car = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Car newCar = new Car
                    (
                    car[0],
                    int.Parse(car[1]),
                    int.Parse(car[2]),
                    int.Parse(car[3]),
                    car[4],
                    double.Parse(car[5]),
                    int.Parse(car[6]),
                    double.Parse(car[7]),
                    int.Parse(car[8]),
                    double.Parse(car[9]),
                    int.Parse(car[10]),
                    double.Parse(car[11]),
                    int.Parse(car[12])
                    );

                cars.Add(newCar);
            }

            string getCommand = Console.ReadLine();

            IEnumerable<Car> carFragile = new List<Car>();
            IEnumerable<Car> carFlammable = new List<Car>();

            if (getCommand == "fragile")
            {
                carFragile = cars.Where(x => x.Cargo.Type == "fragile" &&
                (x.Tires.Tyre1Pressure < 1 || x.Tires.Tyre2Pressure < 1 || x.Tires.Tyre3Pressure < 1 || x.Tires.Tyre4Pressure < 1));

                foreach (var element in carFragile)

                    Console.WriteLine(element.Model);

            }
            if (getCommand == "flammable")
            {
                carFlammable = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250);

                foreach (var element in carFlammable)

                    Console.WriteLine(element.Model);

            }

        }

    } 
}
    
