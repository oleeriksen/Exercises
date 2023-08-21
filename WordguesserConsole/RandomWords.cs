using System;
namespace WordguesserConsole
{
    class RandomWords
    {


        string[] m__words;
        Random randomizer;

        public RandomWords()
        {
            randomizer = new Random();
            m__words = new string[] { "Skanderborg",
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
                                      "Malling"};
        }

        public string GetNext()
        {
            int idx = randomizer.Next(m__words.Length);
            return m__words[idx];
        }

        public string GetHint() {
            return "Byer i omegnen af Aarhus";
        }

    }
}

