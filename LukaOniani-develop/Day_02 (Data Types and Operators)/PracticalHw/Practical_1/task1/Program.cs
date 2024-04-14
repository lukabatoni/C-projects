//a)

int a = 5;
System.Console.WriteLine(a);
int b = 7;
System.Console.WriteLine(b);
int c = 0;
c=a;
a=b;
b=c;
System.Console.WriteLine(a);
System.Console.WriteLine(b);

//b

int a1 = 5;
int b1 = 7;
System.Console.WriteLine(a1);
System.Console.WriteLine(b1);

a1 = a1 + b1;
b1 = a1 - b1;
a1 = a1 - b1;

System.Console.WriteLine(a1);
System.Console.WriteLine(b1);