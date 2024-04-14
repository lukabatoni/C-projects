using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Application.Exceptions
{
    public class CompanyHasDuplicateException : Exception
    {
        public string Code = "CompanyAlreadyExists";

        public CompanyHasDuplicateException(string message) : base(message)
        {

        }
    }
}
