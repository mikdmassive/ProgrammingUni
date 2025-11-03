//data
string historyfile = "history.txt";
string wordsfile = "words.txt";
//functions
void CheckFiles()
{
    if (!File.Exists(historyfile))
    {
        File.Create(historyfile).Close();
    }
    if (!File.Exists(wordsfile))
    {
        File.Create(wordsfile).Close();
        File.WriteAllLines(wordsfile, new string[] { "horse", "banana", "cheese", "chicken", "aggrigate" });
    }
}
string LoadWord()
{
    if (File.Exists(wordsfile))
    {
        List <string> words = File.ReadAllLines(wordsfile).ToList();
        Random rand = new Random();
        return words[rand.Next(0,words.Count)];
    }
    else
    {
        return "error";
    }
}
string Prompt(string txt)
{
    Console.Write(txt);
    return Console.ReadLine();
}

void PlayGame()
{
    if (File.Exists(wordsfile))// word file found
    {
        Console.Clear();
        Console.WriteLine("== MATCH STARTED ==");
        string word = LoadWord();
        bool playing = true;
        string displayedword = new string('_', word.Length);
        List<int> revealedIndexes = new List<int>();
        int guesses = 0;
        bool win = false;
        while (playing)
        {
            Console.WriteLine(displayedword);
            string guess = Prompt("Enter your guess: ");

            guesses += 1;
            if (guess.ToUpper() == word.ToUpper())//if correct
            {
                playing = false;
                win = true;
                Console.WriteLine($"You win! The word was {word} and you guessed it in {guesses} guesses.");
            }
            else//if wrong
            {
                if (guesses == word.Length) //if out of guesses
                {
                    playing = false;
                    Console.WriteLine($"You Lose! The word was {word}.");
                }
                else//still have guesses
                {
                    int RandomIndex()
                    {
                        Random rand = new Random();
                        return rand.Next(0, word.Length);
                    }

                    int index = RandomIndex();
                    while (revealedIndexes.Contains(index))
                    {
                        index = RandomIndex();
                    }
                    char revealedchar = word[index];
                    revealedIndexes.Add(index);
                    char[] displayedarray = displayedword.ToCharArray();
                    displayedarray[index] = revealedchar;
                    displayedword = new string(displayedarray);

                }
            }
        }
        while (!File.Exists(historyfile))
        {
            Console.WriteLine("History file not found, creating new one..");
            CheckFiles();
        }
        File.AppendAllText(historyfile, $"{word},{win},{guesses}\n");
        Console.WriteLine("Match saved successfully!");

    }
    else// fix if not there
    {
        Console.WriteLine("Words file not found, creating new one..");
        CheckFiles();
    }
}
void ViewHistory()
{
    if (File.Exists(historyfile))// history file found
    {
        Console.Clear();
        List<string> history = File.ReadAllLines(historyfile).ToList();
        if (history.Count == 0)
        {
            Console.WriteLine("No history found.");
            return;
        }
        else
        {
            Console.WriteLine("== HISTORY ==");
        }
        foreach (string match in history)
        {
            List<string> stats = match.Split(',').ToList();
            if (stats.Count < 3) continue; //skip invalid lines
            string word = stats[0];
            string result = stats[1] == "True" ? "Win" : "Lose";
            string guesses = stats[2];
            Console.WriteLine($"Word: {word} | Result: {result} | Guesses: {guesses}");
        }
    }
    else//fix if not there
    {
        Console.WriteLine("History file not found, creating new one..");
        CheckFiles();
    }
  
}
//main
CheckFiles();
Console.WriteLine("Welcome to WORDULL!");
bool running = true;
while (running)
{
    
    Console.WriteLine("== MAIN MENU ==\n1) Play Game\n2) View History\n3) Quit");
    string choice = Prompt("Enter your choice: ");
    switch (choice)
    {
        case "1":
            PlayGame();
            break;
        case "2":
            ViewHistory();
            break;
        case "3":
            running = false;
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;

    }
    if (running)
    {
        Prompt("Press Enter to continue...");
        Console.Clear();
    }
}