Console.WriteLine("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());

switch(year % 12){
    case 0:
        Console.WriteLine(Convert.ToString(year) + " is Monkey year");
        break;

    case 1:
        Console.WriteLine(Convert.ToString(year) + " is Rooster year");
        break;

    case 2:
        Console.WriteLine(Convert.ToString(year) + " is Dog year");
        break;
    
    case 3:
        Console.WriteLine(Convert.ToString(year) + " is Pig year");
        break;

    case 4:
        Console.WriteLine(Convert.ToString(year) + " is Rat year");
        break;
    
    case 5:
        Console.WriteLine(Convert.ToString(year) + " is Ox year");
        break;

    case 6:
        Console.WriteLine(Convert.ToString(year) + " is Tiger year");
        break;  

    case 7:
        Console.WriteLine(Convert.ToString(year) + " is Rabbit year");
        break; 

    case 8:
        Console.WriteLine(Convert.ToString(year) + " is Dragon year");
        break; 
    
    case 9:
        Console.WriteLine(Convert.ToString(year) + " is Snake year");
        break;
    
    case 10:
        Console.WriteLine(Convert.ToString(year) + " is Horse year");
        break;
    
    case 11:
        Console.WriteLine(Convert.ToString(year) + " is Goat year");
        break;

    default:
        Console.WriteLine("error");
        break;
    
}