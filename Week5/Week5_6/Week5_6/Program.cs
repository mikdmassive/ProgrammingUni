List<int> GenerateFibonacciSequence(int howmany)
{
    List<int> fibonacci = new List<int>();
    for (int i = 0;i< howmany; i++)
    {
        if(i==0||i == 1)
        {
            fibonacci.Add(i);
        }
        else
        {
            fibonacci.Add(fibonacci[i-1] + fibonacci[i-2]);
        }
    }
    return fibonacci;
}
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
int PromptInt(string txt)
{
    return Convert.ToInt32(Prompt(txt));
}
//main
int howmany = PromptInt("How many Fibonacci numbers would you like to generate?");
List<int> fibonacci = GenerateFibonacciSequence(howmany);
Console.WriteLine($"The first {howmany} Fibonacci numbers are: {string.Join(", ", fibonacci)}");