namespace WordguesserConsole;

public class App
{
    private RandomWords randomWords = new();
    
    /// <summary>
    /// Execute the wordguesser game
    /// </summary>
    public void Run()
    {
        Console.WriteLine("Welcome to Word Guesser");
        Console.WriteLine($"Hint: {randomWords.Hint}");
        bool goOn = true;
        while (goOn)
        {
            string wordToGuess = randomWords.GetNext;
            goOn = OneGame(wordToGuess);
        }
        Console.WriteLine("Terminating the game...");
    }


    /// <summary>
    /// Execute one game
    /// </summary>
    /// <param name="w">the word to guess</param>
    /// <returns>true if we should continue</returns>
    private bool OneGame(string w)
    {
        SecretWord sc = new SecretWord(w, '*');
        Console.WriteLine($"The length of the word is {sc.Length}");
        while (!sc.IsGuessed)
        {
            Console.Write(sc.AsString());
            Console.Write($" Used: {sc.UsedChars}. Enter: ");
            char input = Console.ReadLine()[0];
            sc.Guess(input);
        }

        Console.WriteLine($"You guessed {w}! Used only {sc.NoGuesses} guesses!");
        Console.WriteLine("Continue ? (Y/N)");
        string answer = Console.ReadLine();
        return answer.ToLower() == "y"; 
    }
}