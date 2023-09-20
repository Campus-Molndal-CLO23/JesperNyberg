using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        private string correctWord;
        private string gameField;
        private List<string> guessedLetters;
        private int guessesLeft = 11;
        private bool gameOver = false;
        private bool isWinner = false;

        public Program()
        {
            guessedLetters = new List<string>();
            guessesLeft = 11;
            gameOver = false;
            isWinner = false;
        }

        private void SetupGame()
        {
            Database database = new Database();
            correctWord = database.getRandomWord();

            foreach (char letter in correctWord)
            {
                gameField += "_";
            }
        }

        private void UpdateGameField(int index, string letter)
        {
            gameField = gameField.Remove(index, 1).Insert(index, letter);
        }

        private void PrintGameField()
        {
            Console.WriteLine();
            Console.WriteLine(gameField);
        }

        private void PrintGuessedLetters()
        {
            Console.Write("Gissade bokstäver: ");
            foreach (string letter in guessedLetters)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }

        private void PrintRemainingGuesses()
        {
            Console.WriteLine("Antal gissningar kvar: " + guessesLeft);
        }

        private string MakeGuess()
        {
            Console.Write("Ange en gissning: ");
            string input = Console.ReadLine().ToString().ToLower();

            return input;
        }

        private List<int> ControlLetter(string letter)
        {
            Program program = new Program();
            Console.WriteLine(program.correctWord);
            List<int> positions = new List<int>();

            for (int i = 0; i < correctWord.Length; i++)
            {
                if (correctWord[i].ToString() == letter)
                {
                    positions.Add(i);
                }
            }

            return positions;
        }

        private void PrintEndMessage()
        {
            if (isWinner) Console.WriteLine("Grattis du vann!");
            else Console.WriteLine("Tyvärr, du förlorade!");
        }

        private void GamePlay(Program program)
        {
            do
            {
                program.PrintGameField();
                program.PrintGuessedLetters();
                program.PrintRemainingGuesses();
                string guess = program.MakeGuess();

                if (!Regex.IsMatch(guess, @"^[a-z]+$")) {
                    Console.WriteLine("Endast bokstäver tillåtna!");
                    program.MakeGuess();
                };

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Du har redan gissat på " + guess);
                    program.MakeGuess();
                }

                List<int> positions = program.ControlLetter(guess);

                if (positions.Count == 0)
                {
                    Console.WriteLine("FEL!");
                    guessesLeft--;
                }
                else
                {
                    Console.WriteLine("RÄTT!");
                    foreach (int position in positions) program.UpdateGameField(position, guess);

                }
                guessedLetters.Add(guess);

                if (guessesLeft == 0 || !gameField.Contains("_")) gameOver = true;

            } while (!gameOver);

            if (!gameField.Contains("_")) isWinner = true;

            program.PrintEndMessage();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Välkommen till Jespers Hänga Gubbe!");
            program.SetupGame();
            program.GamePlay(program);
            Console.Read();
        }
    }
}
