int clamp(int number,int min,int max)
{
    if (number < min) return min;
    else if(number > max) return max;
    else return number;
}
int intprompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void promptclamp()
{
    int number = intprompt("Enter a number:");
    int min = intprompt("Enter the minimum value:");
    int max = intprompt("Enter the maximum value:");
    int clampedValue = clamp(number, min, max);
    Console.WriteLine($"Clamped value: {clampedValue}");
    Console.WriteLine();
}

for (int i = 0; i < 3; i++)
{
    promptclamp();
}