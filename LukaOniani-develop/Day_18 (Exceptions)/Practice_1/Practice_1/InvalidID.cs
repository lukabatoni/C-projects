using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class InvalidID : Exception
    {
        public InvalidID(string msg) : base(msg) 
        { 
        }
    }
}
