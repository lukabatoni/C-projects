using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Application.Exceptions
{
    public class ToDoAlreadyExistsException : Exception
    {
        public ToDoAlreadyExistsException() : base() { }
        public ToDoAlreadyExistsException(string message) : base(message) { }

        public readonly string Code = "To-Do Already Exists";

    }
}

