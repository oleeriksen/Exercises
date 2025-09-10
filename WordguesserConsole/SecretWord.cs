namespace WordguesserConsole;

/**
* Represent a secret word. You can guess on a secret word, and you can
* get it with not guessed chars as *'s.
*/
public class SecretWord
{

    private string mContent;
    // the string to hide
    
    private bool[] guessed;
    // guessed[i] indicates if the i'th char is guessed
    
    private char mHiddenChar;
    // the char to use for chars not guessed
    
    private int noGuess = 0;
    // the number of guesses
    
    private string mGuessedChars = "";
    // the guesses - without duplicates

    /// <summary>
    /// </summary>
    /// <param name="content">the secret word to guess</param>
    /// <param name="hiddenChar">to char to show for not guessed chars</param>
    public SecretWord(string content, char hiddenChar = '*')
    {
        mContent = content;
        mHiddenChar = hiddenChar;
        guessed = new bool[content.Length];
    }

    /// <summary>
    /// Make a guess.
    /// </summary>
    /// <param name="ch">the guess</param>
    public void Guess(char ch)
    {
        noGuess++;

        if (!mGuessedChars.Contains(ch))
            mGuessedChars += ch;

        for (int i = 0; i < mContent.Length; i++)
            if (mContent[i] == ch)
                guessed[i] = true;
    }

    
    public int NoGuesses => noGuess;

    /// <summary>
    /// True if the whole word is guessed
    /// </summary>
    public bool IsGuessed
    {
        get
        {
            foreach (bool g in guessed)
                if (!g) return false;
            return true;
        }
    }

    public int Length => mContent.Length; 
        

    /// <summary>
    /// Compute a printable version of the secret word
    /// </summary>
    /// <returns>The secret word with a special char for all positions
    /// that are not guessed yet</returns>
    public string AsString()
    {
        string res = "";
        for (int i = 0; i < guessed.Length; i++)
        {
            if (guessed[i])
                res += mContent[i];
            else
                res += mHiddenChar;
                
        }
        return res;
    }


    /// <summary>
    /// All the chars that is used so far
    /// </summary>
    public string UsedChars => mGuessedChars;

}