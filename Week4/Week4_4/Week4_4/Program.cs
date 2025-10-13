int RangeFunc(int min, int max)
{
    
    Console.WriteLine($"Enter a number between {min} and {max}:");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    
    if (num>=min && num<=max)
    {
        Random ran = new Random();
        result = ran.Next(min,num);
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        result = RangeFunc(min, max);
    }

    return result;
}
string Prompt(string txt)
{

    Console.WriteLine(txt);
    return Console.ReadLine();
}
int PromptInt(string txt)
{

    return Convert.ToInt32(Prompt(txt));
}

//main
int result = RangeFunc(PromptInt("Enter a minimum value: "), PromptInt("Enter a maximum value: "));
Console.WriteLine($"A number in the range is {result}");