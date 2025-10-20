
//functions
bool DoesListContain(List<float> numbers, float numbertofind)
{
    bool found = false;
    foreach (float number in numbers)
    {
        if (number == numbertofind)
        {
            found = true;
        }
    }
    return found;
}
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
float PromptFloat(string txt)
{
    return Convert.ToSingle(Prompt(txt));
}
//main
List<float> numbers = new List<float>() { 3.5f, 7.2f, 1.8f, 9.4f, 5.6f };
float numbertofind = PromptFloat("Enter a number to find in the list:");
Console.WriteLine($"The list {(DoesListContain(numbers,numbertofind) ? "has" : "doesn't have")} {numbertofind}");
