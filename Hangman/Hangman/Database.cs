using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Database
    {
        private string[] words = { "ishockey", "bandyspelare", "glasstrut", "fotbollsmål", "frisbeegolf", "pruttkudde", "lasagne", "drakflygning", "fläskläpp",
        "byhåla", "leverpastej", "samhällstjänst", "marknadsföring", "utlandsresa", "målgest", "fingerborg", "pappersark", "djuprengöring", "biltvätt"};

        internal string getRandomWord()
        {
            Random random = new Random();
            return words[random.Next(0, words.Length)];
        }
    }
}
