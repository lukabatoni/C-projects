using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
        public class MyException : Exception
        {
            public MyException(string message) : base(message)
            {
                using StreamWriter Logger = new StreamWriter(GeographicEntity.GetPathLogs());
                Logger.WriteLine(message);
            }
        }

        public class CountryMustHaveSingleCapital : Exception
        {
            public CountryMustHaveSingleCapital() : base("Country Must Have a Single Capital")
            {
                using StreamWriter Logger = new StreamWriter(GeographicEntity.GetPathLogs());
                Logger.WriteLine("Country Must Have a Single Capital");
            }
        }
}

