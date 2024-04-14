using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditIBAN creditAcc = new CreditIBAN("123123");
            User user1 = null;

            try
            {
                user1 = new User("Luka", "Oniani", "00001144777", creditAcc);
                
            }
            catch (InvalidID ex)
            {

                Console.WriteLine(ex.Message);
            }
            if (user1 != null)
            {
                user1.Deposit(200);
                user1.Withdraw(100);
                user1.Deposit(700);
                user1.Withdraw(200);
                user1.Withdraw(700);
            }


            //TEST ExceptionPring CASS

            static string AvgBalance(double balance, int number)
            {
                double res = 0;
                string lastInnerMessage = "";
                string allMessages = "";

                try
                {
                    if (number == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    res = balance / number;
                }
                catch (DivideByZeroException ex)
                {
                    lastInnerMessage = ExceptionPrint.GetLastInnerExMessage(ex);
                    allMessages = ExceptionPrint.GetAllInnerExMessageTogether(ex);
                    return $"Error occurred: {lastInnerMessage} {allMessages}";
                }

                return $"Average: {res}";
            }

            Console.WriteLine(AvgBalance(user1.Acc.Balance, 0));

        }
    }
}
