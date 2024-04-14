using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class User
    {
        public User(string name, string surname, string id, IBAN acc)
        {
            Name = name;
            Surname = surname;
            if (id.Length != 11)
            {
                throw new InvalidID("ID is incorrect!");
            }
            ID = id;
            Acc = acc;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
        public IBAN Acc {  get; set; }

        public void Deposit(double money)
        {
            Acc.DepositMoney(money);
            Console.WriteLine($"Deposited: {money}");
            Console.WriteLine($"Balance: {Acc.Balance}");
            Console.WriteLine();
        }

        public void Withdraw(double money)
        {
            try
            {
                Acc.WithdrawMoney(money);
                Console.WriteLine($"Withdrawed: {money}");
                
            }
            catch (InvalidTransactionRequest ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Balance: {Acc.Balance}");
                Console.WriteLine();
            }
        }
    }
}
