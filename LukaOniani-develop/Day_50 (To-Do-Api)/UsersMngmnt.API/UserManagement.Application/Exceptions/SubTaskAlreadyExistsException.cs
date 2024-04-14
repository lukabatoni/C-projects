using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Application.Exceptions
{
    public class SubTaskAlreadyExistsException : Exception
    {
        
            public SubTaskAlreadyExistsException() : base() { }
            public SubTaskAlreadyExistsException(string message) : base(message) { }

            public readonly string Code = "Sub-Task Already Exists";

        
    }
}
