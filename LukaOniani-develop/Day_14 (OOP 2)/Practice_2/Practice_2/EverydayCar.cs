using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practice_2
{
    public class Sedan : IVehicleProperties
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public void FillProperties()
        {
            Console.Write("Enter Mark name: ");
            Mark = Console.ReadLine();

            Console.Write("Enter Model name: ");
            Model = Console.ReadLine();

            Console.Write("Enter Sedan Year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Object created!");
            Console.WriteLine($"Mark for Sedan: {Mark}, Model: {Model}, Year: {Year}");
        }
        public void Drive()
        {
            Console.WriteLine("Sedan is Driving");
        }
            
    }

    public class Jeep : IVehicleProperties
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
            Console.WriteLine($"Mark for Jeep: {Mark}, Is 4x4 -{Is4x4}");

        }
        public void Drive()
        {
            Console.WriteLine("Jeep is Driving");
        }

    }

    public class Motorcycle : IVehicleProperties
    {
        public int Speed { get; set; }
        public string Model { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter How fast it can go: ");
            Speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Model Name: ");
            Model = Console.ReadLine();

            Console.WriteLine("Object created!");
            Console.WriteLine($"Speed for Motorcycle: {Speed}, Model: {Model}");
        }


        public void Drive()
        {
            Console.WriteLine("Motorcycle is Driving");
        }

    }

    public class Bike : IVehicleProperties
    {
        public int NumberOfWheels { get; set; }
        public string ManufacturerCountry { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter Number of wheels: ");
            NumberOfWheels = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Manufacturer country: ");
            ManufacturerCountry = Console.ReadLine();

            Console.WriteLine("Object created!");
            Console.WriteLine($"Number of wheels: {NumberOfWheels}, Manufacturer Country: {ManufacturerCountry}");
        }
        public void Drive()
        {
            Console.WriteLine("Bike is Riding");
        }

    }

    public class EverydayCar : Vehicle
    {
        public override void ChooseType()
        {
            Console.WriteLine("Choose EverydayCar type: Sedan, Jeep, Motorcycle, or Bike");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "sedan":
                    Sedan sedan = new Sedan();
                    sedan.FillProperties();
                    sedan.Drive();
                    break;

                case "jeep":
                    Jeep jeep = new Jeep();
                    jeep.FillProperties();
                    jeep.Drive();
                    break;

                case "motorcycle":
                    Motorcycle motorcycle = new Motorcycle();
                    motorcycle.FillProperties();
                    motorcycle.Drive();
                    break;

                case "bike":
                    Bike bike = new Bike();
                    bike.FillProperties();
                    bike.Drive();
                    break;

                default:
                    Console.WriteLine("Invalid choice for EverydayCar type");
                    break;
            }
        }
    }
}
