using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    public class Bus : IVehicleProperties
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }

        public void FillProperties()
        {
            Console.Write("Enter Mark name: ");
            Mark = Console.ReadLine();

            Console.Write("Enter Model name: ");
            Model = Console.ReadLine();

            Console.Write("Enter Sedan Capacity: ");
            Capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Object created!");
            Console.WriteLine($"Mark for Sedan: {Mark}, Model: {Model}, Capacity: {Capacity}");
        }
        public void Drive()
        {
            Console.WriteLine("Bus is Driving");
        }
    }

    public enum TramType
    {
        SingleTrack,
        DoubleTrack
    }

    public class Tramway : IVehicleProperties
    {
        public TramType Type { get; set; }
       

        public void FillProperties()
        {
            Console.WriteLine("Choose Tramway type: SingleTrack or DoubleTrack");
            string choice = Console.ReadLine();

            if (Enum.TryParse(choice, out TramType tramType))
            {
                Type = tramType;
            }
            else
            {
                Console.WriteLine("Invalid choice for Tramway type");
            }
            Console.WriteLine("Object created!");
            Console.WriteLine($"Type for Tramway: {Type}");
        }

        public void Drive()
        {
            Console.WriteLine("Tramway is Driving");
        }
    }



    public class PublicTransport : Vehicle
    { 
        public override void ChooseType()
        {
            Console.WriteLine("Choose PublicTransport type: Bus or Tramway");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "bus":
                    Bus bus = new Bus();
                    bus.FillProperties();
                    bus.Drive();
                    break;

                case "tramway":
                    Tramway tramway = new Tramway();
                    tramway.FillProperties();
                    tramway.Drive();
                    break;

                default:
                    Console.WriteLine("Invalid choice for PublicTransport type");
                    break;
            }
        }
    }
}
