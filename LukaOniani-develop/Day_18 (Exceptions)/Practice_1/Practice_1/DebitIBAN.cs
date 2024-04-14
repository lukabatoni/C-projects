using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class DebitIBAN : IBAN
    {
        public DebitIBAN(string accCode) : base(accCode)
        {
        }

        public override void DepositMoney(double money)
        {
            base.DepositMoney(money);
        }
    }
}
