using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class DateAndTimeExtension
    {
        public static string PrintDayOfWeek(this DateTime date)
        {
            return $"{date.DayOfWeek} {date:dd/MM/yyyy HH:mm:ss:fff}";
        }

        public static bool IsInRange(this DateTime current, DateTime start, DateTime end)
        {
            return start <= current && end >= current;
        }

        public static int CalculateAge (this DateTime age, DateTime date)
        {
            DateTime now = DateTime.Now;
            int ageOfPerson = now.Year - date.Year;
            if (date.Month <= now.Month && date.Day > now.Day)
            {
                ageOfPerson--;
            }

            return ageOfPerson;
        }
    }
}
