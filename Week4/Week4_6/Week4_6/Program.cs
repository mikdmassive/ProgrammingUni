void OutputStringStats(StringStats _string)
{
    
    //outputs
    Console.WriteLine($"The string '{_string._string}' has:");
    w(_string.length, "characters");
    w(_string.uppercase, "uppercase");
    w(_string.lowercase, "lowercase");
    w(_string.digits, "digits");
    w(_string.symbols, "symbols");
    Console.WriteLine($"- and {(_string.spaces ? "has" : "doesn't have")} spaces");

}

string Prompt(string txt)
{

    Console.WriteLine(txt);
    return Console.ReadLine();
}
void w(int stat, string txt)
{
    Console.WriteLine($"- {stat} {txt}");
}

//main
StringStats YourString = new StringStats(Prompt("Enter a string:"));
OutputStringStats(YourString);
//classes
class StringStats
{
    public string _string;
    public int length;
    public int uppercase;
    public int lowercase;
    public int digits;
    public int symbols;
    public bool spaces;

    public StringStats(string _string)
    {
        this._string = _string;
        this.length = _string.Length;
        for (int i = 0; i < length; i++)
        {
            char stringaschar = _string[i];
            string letter = Convert.ToString(stringaschar);

            if (char.IsUpper(stringaschar))
            {
                uppercase++;
            }
            else if (char.IsLower(stringaschar))
            {
                lowercase++;
            }
            else if (char.IsSymbol(stringaschar) || char.IsPunctuation(stringaschar))
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
    }
}