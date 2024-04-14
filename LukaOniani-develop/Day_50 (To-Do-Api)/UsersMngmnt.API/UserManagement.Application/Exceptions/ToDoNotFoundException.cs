using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Application.Exceptions
{
    public class ToDoNotFoundException : Exception
    {
        public ToDoNotFoundException() : base() { }
        public ToDoNotFoundException(string message) : base(message) { }
        public readonly string Code = "To-Do History Not Found";
    }
}
