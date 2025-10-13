//Functions
int Sum1ToN(int n)
{
    int sum = 0;
    for (int i = 1;i<=n;i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Enter a number:");
int amount = Convert.ToInt32(Console.ReadLine());
int result = Sum1ToN(amount);
Console.WriteLine($"The sum of numbers from 1 to {amount} (inclusive) is {result}");
