Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a <= b+c && b <= a+c && c <= a+b) Console.WriteLine("This should be a triangle !");
else Console.WriteLine("This should NOT be a triangle !");