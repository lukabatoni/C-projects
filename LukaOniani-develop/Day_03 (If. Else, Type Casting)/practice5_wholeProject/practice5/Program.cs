Console.WriteLine("Enter your day of birth: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your month of birth (1st letter with capital): ");
string month = Console.ReadLine();

switch (month)
{
    case "January":
        if (day >= 20) Console.WriteLine(Convert.ToString(day) + " " + month + " is Aquarius");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Capricorn");
        break;

    case "February":
        if (day >= 19) Console.WriteLine(Convert.ToString(day) + " " + month + " is Pisces");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Aquarius");
        break;
    
    case "March":
        if (day >= 21) Console.WriteLine(Convert.ToString(day) + " " + month + " is Aries");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Pisces");
        break;
    
    case "April":
        if (day >= 20) Console.WriteLine(Convert.ToString(day) + " " + month + " is Taurus");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Aries");
        break;
    
    case "May":
        if (day >= 21) Console.WriteLine(Convert.ToString(day) + " " + month + " is Gemini");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Taurus");
        break;
    
    case "June":
        if (day >= 21) Console.WriteLine(Convert.ToString(day) + " " + month + " is Cancer");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Gemini");
        break;
    
    case "July":
        if (day >= 23) Console.WriteLine(Convert.ToString(day) + " " + month + " is Leo");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Cancer");
        break;
    
    case "August":
        if (day >= 23) Console.WriteLine(Convert.ToString(day) + " " + month + " is Virgo");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Leo");
        break;
    
    case "September":
        if (day >= 23) Console.WriteLine(Convert.ToString(day) + " " + month + " is Libra");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Virgo");
        break;
    
    case "October":
        if (day >= 23) Console.WriteLine(Convert.ToString(day) + " " + month + " is Scorpio");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Libra");
        break;
    
    case "November":
        if (day >= 22) Console.WriteLine(Convert.ToString(day) + " " + month + " is Sagittarius");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Scorpio");
        break;

    case "December":
        if (day >= 22) Console.WriteLine(Convert.ToString(day) + " " + month + " is Capricorn");
        else Console.WriteLine(Convert.ToString(day) + " " + month + " is Saggitarius");
        break;
    
    default:
        Console.WriteLine("write the first letter of the month in capital");
        break;
}
