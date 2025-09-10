using System;
namespace WordguesserConsole;

class RandomWords
{
    private string[] m_words;
    private Random m_random;

    public RandomWords()
    {
        m_random = new Random();
        m_words =
        [
            "Skanderborg",
            "Silkeborg",
            "Grenå",
            "Horsens",
            "Beder",
            "Odder",
            "Sabro",
            "Harlev",
            "Trige",
            "Hadsten",
            "Hammel",
            "Malling"
        ];
    }

    /// <summary>
    /// get a next random word
    /// </summary>
    public string GetNext 
    {
        get
        {
            int idx = m_random.Next(m_words.Length);
            return m_words[idx];
        }
    }

    public string Hint => "Byer i omegnen af Aarhus";
    

}