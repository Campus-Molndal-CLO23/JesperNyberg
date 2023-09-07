using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TolkienAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainCharacter = "Tansy";
            string adventureGoal = "Hitta den förlorade skatten i Midgård";
            int numberOfAdventurers = 4;
            string[] adventurers = { "Tansy", "Elrohir", "Beorn", "Gimli" };
            string startingPoint = "Shire";
            int journeyDuration = 60;
            string[] dangers = { "orcher", "jättespindlar" };
            string[] aids = { "magisk kompass", "karta" };
            bool isAdventureSuccessful = false;
            int treasureValue = 1000;



            // Berättelsen
            Console.WriteLine($"Det var en gång, i det fridfulla landet {startingPoint}, där bodde en ung hobbit vid namn {mainCharacter}.");
            Console.WriteLine($"En dag fick {mainCharacter} en mystisk inbjudan till ett äventyr. Målet var enkelt: {adventureGoal}.");
            Console.WriteLine($"Med en sammansvärjning av {numberOfAdventurers} äventyrare: {string.Join(", ", adventurers)}, begav de sig ut på en resa som skulle vara i {journeyDuration} dagar.");
            Console.WriteLine($"Beväpnade med {string.Join(" och ", aids)}, visste de att de skulle stöta på faror som {string.Join(" och ", dangers)}.");

            if (isAdventureSuccessful)
            {
                Console.WriteLine($"Efter att ha stött på många faror, lyckades sällskapet i sitt uppdrag. De fann den förlorade skatten, värd {treasureValue} guldmynt, och återvände säkert till {startingPoint}.");
            }
            else
            {
                Console.WriteLine($"Trots deras bästa ansträngningar och de hjälpmedel de bar med sig, misslyckades sällskapet i sitt uppdrag och var tvungna att återvända till {startingPoint} tomhänta.");
            }

            Console.WriteLine("Och så blev berättelsen om deras äventyr en legend, berättad för kommande generationer.");

            Console.Read();

        }
    }
}

