namespace W6T2
{
    public class Program
    {
        //classes
        public class StringInfo
        {
            string str;
            public StringInfo(string str)
            {
                SetString(str);
            }
            public void SetString(string s)
            {
                str = s;
            }
            public int GetUppercaseCount()
            {
                int UppercaseCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    char character = str[i];
                    if (char.IsUpper(character))
                        UppercaseCount++;
                }
                return UppercaseCount;
            }
            public int GetLowercaseCount()
            {
                int LowercaseCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    char character = str[i];
                    if (char.IsLower(character))
                        LowercaseCount++;
                }
                return LowercaseCount;
            }
            public bool ContainsSpace()
            {
                bool space = false;
                for (int i = 0; i < str.Length; i++)
                {
                    char character = str[i];
                    if (char.IsWhiteSpace(character))
                        space = true;
                }
                return space;
            }
            public bool ContainsSymbol()
            {
                bool symbol = false;
                for (int i = 0; i < str.Length; i++)
                {
                    char character = str[i];
                    if (char.IsSymbol(character) || char.IsSeparator(character) || char.IsPunctuation(character))
                        symbol = true;
                }
                return symbol;
            }
            public bool HasAtLeast(int n,char c)
            {
                int samechars = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    char character = str[i];
                    if (character == c)
                        samechars++;
                }
                return (samechars >= n);
            }
            


        }
        //functions
        public static string Prompt(string txt)
        {
            Console.WriteLine(txt);
            return Console.ReadLine();
        }
        //main
        public static void Main(string[] args)
        {
            StringInfo stringInfo = new StringInfo(Prompt("Enter a string:"));
            Console.WriteLine($"Uppercase = {stringInfo.GetUppercaseCount()}");
            Console.WriteLine($"Lowercase = {stringInfo.GetLowercaseCount()}");
            Console.WriteLine($"Has spaces = {stringInfo.ContainsSpace()}");
            Console.WriteLine($"Has symbol = {stringInfo.ContainsSymbol()}");
            int amountToCheck = 3;
            char charToCheck = 'a';
            Console.WriteLine($"Has atleast {amountToCheck} \"{charToCheck}\" = {stringInfo.HasAtLeast(amountToCheck, charToCheck)}");
        }
    }
}