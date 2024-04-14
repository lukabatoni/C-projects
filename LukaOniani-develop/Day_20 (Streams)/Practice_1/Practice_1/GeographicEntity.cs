using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public abstract class GeographicEntity
    {
        public abstract double Area { get; set; }
        public abstract long Population { get; set; }

        public static string GetPathLogs()
        {

            return @"C:\Users\lukaa\Desktop\New folder (2)\Day_20 (Streams)\Logs.txt";
        }
        public static string GetPathCities()
        {
            return @"C:\Users\lukaa\Desktop\New folder (2)\Day_20 (Streams)\Cities.txt";
        }
    }
}
