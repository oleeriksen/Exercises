using System;
namespace WordguesserConsole;

class RandomWords
{
    string[] m_words;
    Random m_random;

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

    public string GetNext()
    {
        int idx = m_random.Next(m_words.Length);
        return m_words[idx];
    }

    public string Hint => "Byer i omegnen af Aarhus";
    

}