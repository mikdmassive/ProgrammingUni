int CalculateCentury(int year)
{
    int Century = year/ 100;
    Century++;


    return Century;
}
//PROMPTS
string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int IntPrompt(string message)
{
    return Convert.ToInt32(Prompt(message));
}
int PromptCalculateCentury()
{
    return CalculateCentury(IntPrompt("Enter a year to calculate its century: "));
}
//Main
Console.WriteLine($"The century is: {PromptCalculateCentury()}");