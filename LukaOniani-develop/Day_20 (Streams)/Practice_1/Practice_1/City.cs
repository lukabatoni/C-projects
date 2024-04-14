using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class City : GeographicEntity
    {
        private string _cityName;
        private string _countryName;
        private bool _isCapital;

        public City(string cityName, double area, long population, bool isCapital, string countryName)
        {
            if (area <= 0)
                throw new MyException("Area must be positive");
            if (population < 0)
                throw new MyException("Population must be positive or zero");

            _cityName = cityName;
            _countryName = countryName;
            _isCapital = isCapital;
            Area = area;
            Population = population;
        }
        public override double Area { get; set; }
        public override long Population { get; set; }
        public string cityName { get { return _cityName; } }
        public string countryName { get { return _countryName; } }
        public bool isCapital {  get { return _isCapital; } }

        public override string ToString()
        {
            return $"City: {cityName}, Area: {Area}, Population: {Population}, Country: {countryName}, Is It Capital? {isCapital}";
        }
    }
}
