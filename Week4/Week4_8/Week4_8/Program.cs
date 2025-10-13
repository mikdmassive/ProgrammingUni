int SimulateElevator(string txt)
{
    int floor = 0;
    for(int i = 0; i<txt.Length; i++)
    {
        if (txt[i] == 'u')
        {
            floor++;
        }
        else if (txt[i] == 'd')
        {
            floor--;
        }
    }
        

    return floor;
}
string Prompt(string txt)
{

    Console.WriteLine(txt);
    return Console.ReadLine();
}
//main
Console.WriteLine($"You are on floor {SimulateElevator(Prompt("Enter a sequence of characters where \"u\" is up and \"d\" is down:"))}");