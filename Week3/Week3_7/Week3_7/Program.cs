string RegistrationToYear(string Registration)
{
    string RegYear = Registration.Substring(2, 2);
    int RegYearInt = int.Parse(RegYear);
    if (RegYearInt>=50)
    {
        int NewRegYearInt = RegYearInt - 50;
        RegYear = Convert.ToString(NewRegYearInt);
        if (NewRegYearInt < 10)
        {
            RegYear = "0" + RegYear;
        }
    }
  
    return "20"+RegYear;
}
//PROMPTS
string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
string PromptRegistrationToYear()
{
    return RegistrationToYear(Prompt("Enter your reg plate:"));
}
//MAIN
Console.WriteLine($"Your car was made in {PromptRegistrationToYear()}");