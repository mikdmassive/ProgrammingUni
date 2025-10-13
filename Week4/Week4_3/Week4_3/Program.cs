//Functions
int Sum1ToN(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
int Product1ToN(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum *= i;
    }
    return sum;
}
void option(int amount)
{
    Console.WriteLine("Would you like to find the sum or product?\n1) Sum\n2) Product\n\nEnter below:");
    string choice = Console.ReadLine();
    int result = 0;
    switch (choice)
    {
        case "1":
            result = Sum1ToN(amount);
            Console.WriteLine($"The sum of numbers from 1 to {amount} (inclusive) is {result}");
            break;
        case "2":
            result = Product1ToN(amount);
            Console.WriteLine($"The product of numbers from 1 to {amount} (inclusive) is {result}");
            break;
        default:
            Console.WriteLine("Invalid choice, try again.");
            option(amount);
            break;
    }
}

//Main

Console.WriteLine("Enter a number:");
int amount = Convert.ToInt32(Console.ReadLine());
option(amount);



