namespace WordguesserConsole
{
    public class App
    {
        RandomWords randomWords = new RandomWords();

        public void Run()
        {
            Console.WriteLine("Welcome to Word Guesser");
            Console.WriteLine("Hint: " + randomWords.GetHint());
            bool goOn = true;
            while (goOn)
            {
                goOn = OneGame(randomWords.GetNext());
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
            Console.WriteLine("The length of the word is " + sc.Length);
            while (sc.IsGuessed == false)
            {
                Console.Write(sc.ToString());
                Console.Write(" Used: [" + sc.UsedChars + "]. Enter: ");
                char input = Console.ReadLine()[0];
                sc.Guess(input);
            }

            Console.WriteLine("You guessed " + w + "! Using only " + sc.NoGuesses + " guesses!");
            Console.WriteLine("Forsæt ? (J/N)");
            string answer = Console.ReadLine();
            return answer.ToLower() == "j"; 
        }
    }
}

