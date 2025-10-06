string GetInsideString(string text) 
{
    string trimmedstring = text.Trim();
    return trimmedstring.Substring(1, trimmedstring.Length - 2);
}
//PROMPTS
string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
string PromptGetInsideString()
{
    return GetInsideString(Prompt("Enter a messy message:"));
}
//Main
Console.WriteLine(PromptGetInsideString());