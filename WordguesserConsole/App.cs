namespace WordguesserConsole;

public class App
{
    RandomWords randomWords = new RandomWords();
        
    public void Run()
    {
        Console.WriteLine("Welcome to Word Guesser");
        Console.WriteLine("Hint: " + randomWords.Hint);
        bool goOn = true;
        while (goOn)
        {
            string wordToGuess = randomWords.GetNext();
            goOn = OneGame(wordToGuess);
        }
    }

    /**
     * Execute one game
     * @param w - the word to guess.
     * Return true if we should continue
     */
    private bool OneGame(string w)
    {
        SecretWord sc = new SecretWord(w, '*');
        Console.WriteLine($"The length of the word is {sc.Length}");
        while ( ! sc.IsGuessed )
        {
            Console.Write(sc.AsString());
            Console.Write($" Used: {sc.UsedChars}. Enter: ");
            char input = Console.ReadLine()[0];
            sc.Guess(input);
        }

        Console.WriteLine("You guessed " + w + "! Using only " + sc.NoGuesses + " guesses!");
        Console.WriteLine("Continue ? (Y/N)");
        string answer = Console.ReadLine();
        return answer.ToLower() == "y"; 
    }
}