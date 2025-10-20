void HigherOrLower()
{
    int lower = 1;
    int upper = 10;
    int numberToGuess = new Random().Next(lower, upper);
    List<int> guesses = new List<int>();
    bool gameover = false;
    int difguesses = 0;
    bool win = false;
    int maxguesses = 4;
    while (!gameover)
    {
        int guess = PromptInt($"Guess a number between {lower} and {upper}, you have {maxguesses-difguesses} guesses left:");
   
        if (!guesses.Contains(guess))
        {
            difguesses++;
        }
        guesses.Add(guess);
        win = (guess == numberToGuess);
        gameover = win || (difguesses >=maxguesses);
        if (!gameover)
        {
            Console.WriteLine(guess < numberToGuess ? "Higher!" : "Lower!");
        }
    }
    Console.WriteLine($"{(win ? $"You win! You guessed {numberToGuess} in {maxguesses} distinct guesses." : "You lose!")} ");
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
HigherOrLower();