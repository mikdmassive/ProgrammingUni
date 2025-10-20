//functions
bool ValidateAnswer(List<string> acceptedanswers, string answer)
{
    bool valid = false;
    foreach (string acceptedanswer in acceptedanswers)
    {
        string upperacceptedanswer = acceptedanswer.ToUpper();
        if (upperacceptedanswer == answer.ToUpper())
        {
            valid = true;
        }
    }
    return valid;
}
void RepeatTillValid(List<string> acceptedanswers, string txt)
{
    bool valid = false;
    while (!valid)
    {
        string answer = Prompt(txt);
        valid = ValidateAnswer(acceptedanswers, answer);
        Console.WriteLine($"{(valid ? "Great Answer!":"Try again..")}");
    }
}
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
//main
List<string> ValidColours = new List<string>() { "Red", "Green", "Blue" };
RepeatTillValid(ValidColours, "Whats your fav colour?");