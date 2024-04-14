using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class ExceptionPrint
    {
        public static string GetLastInnerExMessage(Exception ex)
        {
            Exception exception = ex;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }
            return exception.Message;
        }


        public static string GetAllInnerExMessageTogether(Exception ex)
        {
            StringBuilder allExceptions = new StringBuilder();

            Exception exception = ex;
            while (exception != null)
            {
                allExceptions.Append(exception.Message);
                exception = exception.InnerException;

                if (exception != null)
                {
                    allExceptions.Append(", ");
                }
            }

            return allExceptions.ToString();
        }
    }
}