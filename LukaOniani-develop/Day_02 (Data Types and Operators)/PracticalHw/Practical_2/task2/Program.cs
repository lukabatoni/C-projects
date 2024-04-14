Console.WriteLine("Is this leap year? ");
int year = Convert.ToInt32(Console.ReadLine());

int testYear = year;

if ((testYear % 400 == 0) || (testYear % 4 == 0 && testYear % 100 != 0)){
    Console.WriteLine("True");
}
else Console.WriteLine("False");