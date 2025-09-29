bool loop = true;
while (loop)
{
    Console.Write("Enter a character:");
    string input = Console.ReadLine();
    if (input.Length == 1)
    {
        //char entered
        char inputAsChar = Convert.ToChar(input);
    
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("You entered a number");
        }
        else if (char.IsSymbol(inputAsChar) || char.IsSeparator(inputAsChar) || char.IsPunctuation(inputAsChar))
        {
            Console.WriteLine("You entered a symbol");
        }
        else if (char.IsLetter(inputAsChar))
        {
            Console.WriteLine("You entered a letter");
        }
        Console.WriteLine();
    }
    else 
    {
        Console.WriteLine("Please enter exactly one character.");
    }


}