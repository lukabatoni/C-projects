using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Application.Exceptions
{
    public class CompanyAlreadyExistsException : Exception
    {
        public string Code = "CompanyAlreadyExists";

        public CompanyAlreadyExistsException (string message) : base(message)
        {

        }
    }
}
