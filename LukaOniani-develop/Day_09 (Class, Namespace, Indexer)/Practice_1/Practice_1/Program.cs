using System;

class Cat
{
    private int constGrams = 10;
    public string Name { get; set; }
    public string Breed { get; set; }


    private int _age;
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    private string _sex;
    public string Sex
    {
        get { return _sex; }
        set { _sex = value; }
    }

    public void Meowing(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Meowing...");
        }
       
    }

    public void Eating(int grams)
    {
        Console.WriteLine(Name + " start eating");
        int bites = grams / constGrams;
        int remainingGrams = grams % constGrams;

        if (remainingGrams > 0)
        {
            bites++;
        }

        for (int i = 0; i < bites; i++)
        {
                Console.WriteLine("Eating...");
        }

        Console.WriteLine(Name + " finished eating");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Creating Cat object... ");

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter breed: ");
        string breed = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter sex: ");
        string sex = Console.ReadLine();

        Cat myCat = new Cat
        {
            Name = name,
            Breed = breed,
            Age = age,
            Sex = sex
        };

        Console.WriteLine("Cat object Created. ");


        Console.Write("Enter the amount of food in grams: ");
        int foodAmount = Convert.ToInt32(Console.ReadLine());
        myCat.Eating(foodAmount);

        Console.Write("Enter the amount of meowing: ");
        int meowAmount = Convert.ToInt32(Console.ReadLine());
        myCat.Meowing(meowAmount);

        Console.ReadLine();
    }
}