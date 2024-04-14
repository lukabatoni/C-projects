using System;

class Clock
{
    private int _hour;
    private int _minute;
    private int _second;

    public int Hour
    {
        get { return _hour; }
        set
        {
            if (value >= 0 && value <= 23)
                _hour = value;
            else
                Console.WriteLine("Invalid hour value!");
        }
    }

    public int Minute
    {
        get { return _minute; }
        set
        {
            if (value >= 0 && value <= 59)
                _minute = value;
            else
                Console.WriteLine("Invalid minute value!");
        }
    }

    public int Second
    {
        get { return _second; }
        set
        {
            if (value >= 0 && value <= 59)
                _second = value;
            else
                Console.WriteLine("Invalid second value!");
        }
    }

    public void AddHour()
    {
        _hour++;
        if (_hour > 23)
            _hour = 0;
    }

    public void SubHour()
    {
        _hour--;
        if (_hour < 0)
            _hour = 23;
    }

    public void AddMinute()
    {
        _minute++;
        if (_minute > 59)
        {
            _minute = 0;
            AddHour();
        }
    }

    public void SubMinute()
    {
        _minute--;
        if (_minute < 0)
        {
            _minute = 59;
            SubHour();
        }
    }

    public void AddSecond()
    {
        _second++;
        if (_second > 59)
        {
            _second = 0;
            AddMinute();
        }
    }

    public void SubSecond()
    {
        _second--;
        if (_second < 0)
        {
            _second = 59;
            SubMinute();
        }
    }

    public void PrintTime()
    {
        Console.WriteLine($"Current Time: {_hour:D2}:{_minute:D2}:{_second:D2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter hour: ");
        int hour = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter minute: ");
        int minute = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Clock clock = new Clock
        {
            Hour = hour,
            Minute = minute,
            Second = second
        };

        clock.PrintTime();

        clock.AddSecond();
        clock.PrintTime();

        clock.SubMinute();
        clock.PrintTime();

        Console.ReadLine();
    }
}