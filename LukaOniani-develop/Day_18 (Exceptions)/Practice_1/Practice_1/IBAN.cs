using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class IBAN
    {
        public string AccCode { get; set; }
        public double Balance { get; set; }


        public IBAN(string accCode)
        {
            AccCode = accCode;
            Balance = 0.0;
        }

        public virtual void DepositMoney(double money)
        {
            Balance += money;
        }

        public virtual void WithdrawMoney(double money)
        {
            if (money > Balance)
            {
                throw new InvalidTransactionRequest("Not enough money on account");
            }

            Balance -= money;
        }
    }
}
