using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Application.Exceptions
{
    public class SubTaskNotFoundException : Exception
    {
        public SubTaskNotFoundException() : base() { }
        public SubTaskNotFoundException(string message) : base(message) { }
        public readonly string Code = "Subtask History Not Found";
    }
}
