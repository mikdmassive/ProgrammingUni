
ImperialHeight CreateImperialHeight()
{
    int feet = IntPrompt("Enter feet: ");
    int inches = IntPrompt("Enter inches: ");
    return new ImperialHeight(feet, inches);
}

float ConvertImperialHeightToMetres(ImperialHeight ImpHeight)
{
    return (ImpHeight.feet* 0.3048f) + (ImpHeight.inches * 0.0254f);
}

//PROMPTS
string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int IntPrompt(string message)
{
    return Convert.ToInt32(Prompt(message));
}
void PromptConvertImperialHeightToMetres()
{
    Console.WriteLine($"This is {ConvertImperialHeightToMetres(CreateImperialHeight())} meters");
}
//MAIN
PromptConvertImperialHeightToMetres();

//CLASSES
class ImperialHeight
{
    public int feet;
    public int inches; 
    public ImperialHeight(int feet, int inches)
    {
        this.feet = feet;
        this.inches = inches;
    }
}