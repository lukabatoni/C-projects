using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Country : GeographicEntity
    {
        private string _name;
        private List<City> _cities;

        public Country(string name, List<City> cities)
        {
            _name = name;
            bool hasCapital = false;

            foreach (var city in cities)
            {
                if (hasCapital && city.isCapital)
                    throw new CountryMustHaveSingleCapital();

                if (city.isCapital)
                    hasCapital = true;
            }

            _cities = cities;
        }
        public string countryName { get { return _name; } }
        public List<City> CityList { get { return _cities; } }
        public override double Area
        {
            get
            {
                double totalArea = 0;
                foreach (var city in CityList)
                {
                    totalArea += city.Area;
                }
                return totalArea;
            }
            set { }
        }

        public override long Population
        {
            get
            {
                long totalPopulation = 0;
                foreach (var city in CityList)
                {
                    totalPopulation += city.Population;
                }
                return totalPopulation;
            }
            set { }
        }

        public override string ToString()
        {
            string answer = $"Country : {countryName}, Area: {Area}, Population: {Population}\nCities:\n";
            foreach (var city in CityList)
            {
                answer += city.ToString() + "\n";
            }
            return answer;
        }
    }
}
