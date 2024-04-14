namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            List<Country> countries = new List<Country>();
            var countryMap = new Dictionary<string, List<City>>();
            var cityNameMap = new Dictionary<string, int>();
            var countryNameMap = new Dictionary<string, int>();

            

            using (StreamReader streamReader = new StreamReader(GeographicEntity.GetPathCities()))
            {
                int index = 0;
                var line = streamReader.ReadLine();

                while (line != null && line != "")
                {
                    City city;
                    try
                    {
                        var parameters = line.Split('|');

                        string name = parameters[0];
                        double area = double.Parse(parameters[1].Replace(',', '.'));
                        long population = long.Parse(parameters[2]);
                        bool capital = bool.Parse(parameters[3]);
                        string countName = parameters[4];

                        city = new City(name, area, population, capital, countName);
                    }
                    catch
                    {
                        throw new MyException("Parameters given in Text File are incorrect");
                    }
                    string countryName = city.countryName;

                    cities.Add(city);
                    cityNameMap[city.cityName] = index++;

                    if (!countryMap.ContainsKey(countryName))
                        countryMap[countryName] = new List<City>();
                    countryMap[countryName].Add(city);

                    line = streamReader.ReadLine();
                }
            }

            int indexer = 0;
            foreach (var item in countryMap)
            {
                countries.Add(new Country(item.Key, item.Value));
                countryNameMap[item.Key] = indexer++;
            }

            Console.Write("Choose:\n1.Search Country\n2.Search City\n(write 1 or 2): ");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (input == "1")
            {
                Console.WriteLine("Choose from these countries:");
                foreach (string country in countryMap.Keys)
                    Console.WriteLine(country);
                Console.WriteLine();
                input = Console.ReadLine();
                Console.WriteLine("\n" + countries.ElementAt(countryNameMap[input]));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Choose from these cities:");
                foreach (var city in cities)
                    Console.WriteLine(city.cityName);
                Console.WriteLine();
                input = Console.ReadLine();
                Console.WriteLine("\n" + cities.ElementAt(cityNameMap[input]));
                Console.ReadKey();
            }
        }
    }
}
