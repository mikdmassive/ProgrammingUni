float DoMaths(float number1, float number2, string operation)
{
    switch (operation)
    {
        case "+":
            return (float)(number1 + number2);
        case "-":
            return (float)(number1 - number2);
        case "/":
            return (float)(number1 / number2);
        case "*":
            return (float)(number1 * number2);
        default:
            Console.WriteLine("Invalid operation");
            return 0;
    }
}
string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
float FloatPrompt(string message)
{
    return Convert.ToSingle(Prompt(message));
}
void PromptDoMaths()
{
    float number1 = FloatPrompt("Enter the first number:");
    float number2 = FloatPrompt("Enter the second number:");
    string operator_ = Prompt("Enter the operator:");
    float result = DoMaths(number1, number2, operator_);
    Console.WriteLine($"The result is: {result}");
}
PromptDoMaths();