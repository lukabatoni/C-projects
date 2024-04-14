namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a vehicle category: BattleCar, EverydayCar, PublicTransport, or SportCar");
            string categoryChoice = Console.ReadLine();

            Vehicle selectedVehicle;

            switch (categoryChoice.ToLower())
            {
                case "battlecar":
                    selectedVehicle = new BattleCar();
                    break;
                case "everydaycar":
                    selectedVehicle = new EverydayCar();
                    break;
                case "publictransport":
                    selectedVehicle = new PublicTransport();
                    break;
                case "sportcar":
                    selectedVehicle = new SportCar();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            selectedVehicle.ChooseType();


        }

    }
}
