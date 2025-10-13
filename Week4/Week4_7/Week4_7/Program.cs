string GetBirthCountry()
{
    string birthcountry = Prompt("Please enter your birth country:");
    if (birthcountry.Length<4)
    {
        Console.WriteLine("Please enter atleast 4 characters.\n");
        birthcountry = GetBirthCountry();
    }
    return birthcountry;
}
string Prompt(string txt)
{

    Console.WriteLine(txt);
    return Console.ReadLine();
}
//main
Console.WriteLine($"Birth Country : {GetBirthCountry()}");