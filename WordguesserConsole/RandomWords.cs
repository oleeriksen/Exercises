using System;
namespace WordguesserConsole
{
    class RandomWords
    {
        List<string> m_words;
        Random m_random;

        public RandomWords()
        {
            m_random = new Random();
            m_words = File.ReadAllLines("words.txt").ToList();
            /*m_words = new List<string>() { 
                                      "Skander borg",
                                      "Silke borg",
                                      "Gre nå",
                                      "Hor sens",
                                      "Bed er",
                                      "Od der",
                                      "Sa bro",
                                      "Har lev",
                                      "Tri ge",
                                      "Had sten",
                                      "Ham mel",
                                      "Mal ling"};*/
        }

        public string GetNext()
        {
            int idx = m_random.Next(m_words.Count);
            string result = m_words[idx];
            m_words.RemoveAt(idx);
            return result;
        }

        public string GetHint() {
            return "Byer i omegnen af Aarhus";
        }

        public bool MoreWords => m_words.Count > 0;

    }
}

