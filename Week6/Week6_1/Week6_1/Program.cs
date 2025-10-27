//functions
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
int PromptInt(string txt)
{
    while (true)
    {
        string newtxt = Prompt(txt);
        if (int.TryParse(newtxt, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

}
//main
Date date = new Date();
date.AddDays(PromptInt("How many days do you want to add?"));
Console.WriteLine(date.Formatted());
//classes
class Date
{
    private Dictionary<int,int>DaysInMonth = new Dictionary<int, int>()
    {
        [1]= 31,
        [2] = 28,
        [3] = 31,
        [4] = 30,
        [5] = 31,
        [6] = 30,
        [7] = 31,
        [8] = 31,
        [9] = 31,
        [10] = 31,
        [11] = 30,
        [12] = 31,
    };
    public int day;
    public int month;
    public int year;
    public Date()
    {
        SetYear(PromptInt("Enter the year:"));
        SetMonth(PromptInt("Enter the month:"));
        SetDay(PromptInt("Enter the day:"));
    }
    bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
    int ReturnDaysOfMonth(int month, int year)
    {
        int daytoreturn = DaysInMonth[month];
        if (month == 2 && IsLeapYear(year))
        {
            daytoreturn += 1;
        }
        return daytoreturn;
    }
    public string Prompt(string txt)
    {
        Console.WriteLine(txt);
        return Console.ReadLine();
    }
    public int PromptInt(string txt)
    {
        while (true)
        {
            string newtxt = Prompt(txt);
            if (int.TryParse(newtxt, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

    }
    public void SetDay(int d)
    {
        int max = ReturnDaysOfMonth(month, year);
        while (d < 1 || d > max)
        {
            Console.WriteLine($"Invalid day. Please enter a day between 1 and {max}.");
            d = PromptInt("Enter day:");
        }
        this.day = d;
    }
    public void SetMonth(int m)
    {
        int max = 12;
        while (m < 1 || m > max)
        {
            Console.WriteLine($"Invalid month. Please enter a month between 1 and {max}.");
            m = PromptInt("Enter day:");
        }
        this.month = m;
    }
    public void SetYear(int y)
    {
        while (y < 0)
        {
            Console.WriteLine("Invalid year. Please enter a non-negative year.");
            y = PromptInt("Enter day:");
        }
        this.year = y;
    }
    public void AddDays(int daystoadd)
    {
        int totaldays = day + daystoadd;
        int monthstoadd = 0;
  
        while (true)
        {
            int monthtocheck = month + monthstoadd;
            while (monthtocheck > 12)
            {
                monthtocheck -= 12;
            }
            int daysinmonth = ReturnDaysOfMonth(monthtocheck, year);
            if (totaldays > daysinmonth)
            {
                monthstoadd += 1;
                totaldays -= daysinmonth;
 
            }
            else
            {
                break;
            }
        }
        day = totaldays;
        AddMonths(monthstoadd);
    }
    public void AddMonths(int monthstoadd)
    {
        int totalmonths = month + monthstoadd;
        int yearstoadd = 0;
        while (totalmonths>12)
        {
            yearstoadd += 1;
            totalmonths -= 12;
        }
        month = totalmonths;
        AddYears(yearstoadd);
    }
    public void AddYears(int yearstoadd)
    {
        year += yearstoadd;
    }
    public string Formatted()
    {
        static string FormatPart(int part,int chars)
        {
            string stringpart = Convert.ToString(part);
            int ZerosToAdd = chars - stringpart.Length;
            for (int i = 0; i < ZerosToAdd; i++)
            {
                stringpart = "0" + stringpart;
            }
            return stringpart;
        }
        return ($"{FormatPart(year,4)} - {FormatPart(month, 2)} - {FormatPart(day, 2)}");
    }
}