void OutputStringStats(string _string)
{
    int len = _string.Length;
    int uppercase = 0;
    int lowercase = 0;
    int digits = 0;
    int symbols = 0;
    bool spaces = false;
    for (int i = 0;i< len;i++)
    {
        char stringaschar= _string[i];
        string letter = Convert.ToString(stringaschar);

        if (char.IsUpper(stringaschar))
        {
            uppercase++;
        }
        else if (char.IsLower(stringaschar))
        {
            lowercase++;
        }
        else if (char.IsSymbol(stringaschar)  || char.IsPunctuation(stringaschar))
        {
            symbols++;
        }
        else if (char.IsDigit(stringaschar))
        {
            digits++;
        }
        else if (letter == " ")
        {
            spaces = true;
        }
       
    }
    //outputs
    Console.WriteLine($"The string '{_string}' has:");
    w(len, "characters");
    w(uppercase, "uppercase");
    w(lowercase, "lowercase");
    w(digits, "digits");
    w(symbols, "symbols");
    Console.WriteLine($"- and {(spaces ? "has":"doesn't have")} spaces");

}

string Prompt(string txt)
{

    Console.WriteLine(txt);
    return Console.ReadLine();
}
void w(int stat,string txt)
{
    Console.WriteLine($"- {stat} {txt}");
}

//main
OutputStringStats(Prompt("Enter a string: "));
