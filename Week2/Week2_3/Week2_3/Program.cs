Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
switch (age)
{
    case > 65:
        Console.WriteLine("You are a senior.");
        break;
    case > 20:
        Console.WriteLine("You are a adult.");
        break;
    case > 12:
        Console.WriteLine("You are a teen.");
        break;
    case >= 0:
        Console.WriteLine("You are a child.");
        break;
    default:
        Console.WriteLine("Invalid age.");
        break;
}