using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class CreditIBAN : IBAN
    {
        public CreditIBAN(string accCode) : base(accCode)
        {
        }

        public override void WithdrawMoney(double money)
        {
            base.WithdrawMoney(money);
        }
    }
}
