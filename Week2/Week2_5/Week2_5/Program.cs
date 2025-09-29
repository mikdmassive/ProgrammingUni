int maxlottonums = 6;

int lottonumber()
{
    Random rand = new Random();
    int num = rand.Next(1, 50);
    return num;
}

List<int> createlottonumbers()
{
    List<int> lottonumbers = new List<int>();
    while (lottonumbers.Count < maxlottonums)
    {
        int num = lottonumber();
        if (!lottonumbers.Contains(num))
        {
            lottonumbers.Add(num);
        }
    }
    return lottonumbers;
}

void readlottonumbers(string startermsg,List<int> lottonumbers)
{
    Console.Write(startermsg);
    for (int i = 0; i < lottonumbers.Count;i++)
    {
        int num = lottonumbers[i];
        Console.Write(num);
        if (i!= lottonumbers.Count-1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }

    }
    Console.WriteLine();
}
//loop
while (true)
{
    Console.Write("Press ENTER to play the lottery or type 'exit' to quit: ");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    List<int> userlottonumbers = createlottonumbers();
    List<int> winninglottonumbers = createlottonumbers();

    readlottonumbers("Your lotto numbers are: ", userlottonumbers);
    readlottonumbers("The winning numbers are: ", winninglottonumbers);

    int matches = 0;
    for (int i = 0; i < maxlottonums - 1; i++)
    {
        if (winninglottonumbers.Contains(userlottonumbers[i]))
        {
            matches++;
        }
    }
    if (matches == 6)
    {
        Console.WriteLine("WINNER!!!");
    }
    else
    {
        Console.WriteLine($"THE GAME IS RIGGED!\nYou have {matches} matching number(s)");
    }
    Console.WriteLine();
}