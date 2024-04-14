using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    public class Formula1 : IVehicleProperties
    {
        public string Mark {  get; set; } 
        public int Speed { get; set; }
        public string Driver { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter Mark for F1: ");
            Mark = Console.ReadLine();

            Console.Write("Enter speed for F1: ");
            Speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the driver for F1: ");
            Driver = Console.ReadLine();

            Console.WriteLine("Object created!");
            Console.WriteLine($"Mark for F1: {Mark}, Speed for F1: {Speed}, The Driver for F1: {Driver}");
        }

        public void Drive()
        {
            Console.WriteLine("F1 is Driving");
        }
    }

    public enum SurfaceType
    {
        Gravel,
        Mud,
        Snow,
        Tarmac
    }

    public class Rally : IVehicleProperties
    {
        public string Model { get; set; }
        public SurfaceType SupportedSurface { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter Rally car model: ");
            Model = Console.ReadLine();

            Console.Write("Choose supported surface for Rally car: Gravel, Mud, Snow, Tarmac: ");
            string surfaceChoice = Console.ReadLine();

            if (Enum.TryParse(surfaceChoice, out SurfaceType surface))
            {
                SupportedSurface = surface;
            }
            else
            {
                Console.WriteLine("Invalid surface type for Rally car");
            }

            Console.WriteLine("Object created!");
            Console.WriteLine($"Model for Rally car: {Model}, The surface it can go: {SupportedSurface}");
        }
        public void Drive()
        {
            Console.WriteLine("Rally car is Driving");
        }
    }

    public class Offroad : IVehicleProperties
    {
        public string Mark { get; set; }
        public bool Is4x4 { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter Mark name: ");
            Mark = Console.ReadLine();

            Console.Write("is 4x4? Answer true or false: ");
            if (bool.TryParse(Console.ReadLine(), out bool answer))
            {
                Is4x4 = answer;
            }

            Console.WriteLine("Object created!");
            Console.WriteLine($"Mark for Offroad Car: {Mark}, Is 4x4 -{Is4x4}");

        }

        public void Drive()
        {
            Console.WriteLine("Offroad car is Driving");
        }
    }


        public class SportCar : Vehicle
    {
        public override void ChooseType()
        {
            Console.WriteLine("Choose SportCar type: Formula1, Rally, or Offroad");
            string choice = Console.ReadLine();
            
            switch (choice.ToLower()) 
            {
                case "formula1":
                    Formula1 formula = new Formula1();
                    formula.FillProperties();
                    break;

                case "rally":
                    Rally rally = new Rally();
                    rally.FillProperties();
                    break;

                case "offroad":
                    Offroad offroad = new Offroad();
                    offroad.FillProperties();
                    break;
                default:
                    Console.WriteLine("Invalid SportCar type");
                    break;
            }
        }
    }
}
