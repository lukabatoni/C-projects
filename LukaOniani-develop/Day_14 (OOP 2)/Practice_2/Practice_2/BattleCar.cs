using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    public enum TankType 
    {
        Light,
        Heavy
    }

    public class Tank : IVehicleProperties
    {
        public TankType Type { get; set; }
        public int Killometers { get; set; }



        public void FillProperties()
        {
            Console.Write("Choose Tank type: Light or Heavy: ");
            string typeChoice = Console.ReadLine();

            if (Enum.TryParse(typeChoice, out TankType tankType))
            {
                Type = tankType;
            }
            Console.WriteLine();

            Console.Write("Enter how far a tank can go: ");

            if (int.TryParse(Console.ReadLine(), out int killometers))
            {
                Killometers = killometers;
            }

            Console.WriteLine("Object created!");
            Console.WriteLine($"Type for Tank: {Type}, Killometers it can go: {Killometers}km");
        }

        public void Drive()
        {
            Console.WriteLine("Tank is Driving");
        }
    }

    public class Betterrer : IVehicleProperties
    {
        public string Model { get; set; }
        public int Weight { get; set; }


        public void FillProperties()
        {
            Console.Write("Enter Model Name: ");
            Model = Console.ReadLine();

            Console.Write("Enter Weight for Betterrer");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Object created!");
            Console.WriteLine($"Model for Beterrer: {Model}, Weight: {Weight}");

        }

        public void Drive()
        {
            Console.WriteLine("Betterrer is Driving");
        }
    }

    public class BattleCar : Vehicle
    {
        public override void ChooseType()
        {
            Console.WriteLine("Choose BattleCar type: Tank or Betterrer");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "tank":
                    Tank tank = new Tank();
                    tank.FillProperties();   
                    tank.Drive();
                    break;

                case "betterrer":
                    Betterrer betterrer = new Betterrer();
                    betterrer.FillProperties();
                    betterrer.Drive();
                    break;

                default:
                    Console.WriteLine("Invalid choice for BattleCar type!");
                    break;
            }
        }
    }
}
