using System.Diagnostics;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ElectricCar> cars = new List<ElectricCar>
        {
            new ElectricCar("Toyota Camry", 2019),
            new ElectricCar("Nissan Leaf", 2023),
            new ElectricCar("Chevrolet Bolt", 2021),
            new ElectricCar("Honda Civic", 2022)
        };
         
            Stopwatch stopwatch = Stopwatch.StartNew();
            ChargeAllCars(cars, TimeSpan.FromSeconds(200));
            stopwatch.Stop();

            Console.WriteLine($"Time Total: {stopwatch.Elapsed}");
            Console.WriteLine($"Time taken to charge all cars: {stopwatch.Elapsed.TotalSeconds} seconds");
        }

        static void ChargeAllCars(IEnumerable<ElectricCar> cars, TimeSpan maxTime)
        {
            List<Thread> threads = new List<Thread>();
            foreach (var car in cars)
            {
                Thread thread = new Thread(car.Charge);
                threads.Add(thread);
                thread.Start();
            }

            
            foreach (var thread in threads)
            {
                if (!thread.Join(maxTime))
                {
                    Console.WriteLine("Charging timeout reached!");
                    thread.Abort(); 
                }
            }
        }
    }
}
