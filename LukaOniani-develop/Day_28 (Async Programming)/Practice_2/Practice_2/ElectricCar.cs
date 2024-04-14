using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    public class ElectricCar
    {
        int BatteryLevel { get; set; }
        string Model { get; set; }
        int Year { get; set; }

        public ElectricCar(string model, int year)
        {
            Model = model;
            Year = year;
            BatteryLevel = 0;
        }

        public void Charge()
        {
            while (BatteryLevel < 100)
            {
                BatteryLevel += 5;
                if (BatteryLevel > 100)
                    BatteryLevel = 100;
                Console.WriteLine($"Charging {Model} - Battery Level is: {BatteryLevel}%");
                Thread.Sleep(10000); 
            }
        }
    }
}
