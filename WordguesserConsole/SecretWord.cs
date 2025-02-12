namespace WordguesserConsole
{
    /**
 * Represent a secret word. You can guess on a secret word, and you can
 * get it with not guessed chars as *'s.
 * @author oe
 */
    public class SecretWord
    {

        private string m_content;
           // the string to hide
        private bool[] guessed;
           // guessed[i] indicates if the i'th char is guessed
        private char m_hiddenChar;
           // the char to use for chars not guessed
        private int noGuess = 0;
           // the number of guesses
        private string m_guessedChars = "";
           // the guesses - without duplicates

        /**
         * 
         * @param content is the string hidden in the secret word
         * @param hiddenChar is the char to show a not guessed char
         */
        public SecretWord(string content, char hiddenChar)
        {
            m_content = content;
            m_hiddenChar = hiddenChar;
            guessed = new bool[content.Length];
        }

        /**
         * Make a guess. The secret word keeps the number of guesses done
         * @param ch the char guessed
         */
        public void Guess(char ch)
        {
            noGuess++;

            if (!m_guessedChars.Contains(ch))
                m_guessedChars += ch;

            for (int i = 0; i < m_content.Length; i++)
                if (m_content[i] == ch)
                    guessed[i] = true;
        }

        /**
         * @return how many guesses done 
         */
        public int NoGuesses
        { get { return noGuess; } }

        /**
         * @return true iff all char are guessed 
         */
        public bool IsGuessed
        {
            get
            {
                for (int i = 0; i < guessed.Length; i++)
                    if (!guessed[i]) return false;
                return true;
            }
        }

        public int Length
        {
            get { return m_content.Length; }
        }

        /**
         * 
         * @return the secret word with a m_hiddenChar on all positions
         * where a not guessed char occur.
         */
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < guessed.Length; i++)
            {
                if (guessed[i])
                    res += m_content[i];
                else
                    res += m_hiddenChar;
                
            }
            return res;
        }


        public string UsedChars 
        {
            get { return m_guessedChars; }
        }

    }
}

