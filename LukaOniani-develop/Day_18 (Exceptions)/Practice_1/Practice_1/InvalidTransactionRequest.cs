using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class InvalidTransactionRequest : Exception
    {
        public InvalidTransactionRequest(string msg) : base(msg) 
        {
        }
    }
}
