using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class Program
    {
        /// <summary>
        /// Jeu mastermind
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string goal = "GYWR";
            char firstLetter;
            char secondLetter;
            char thirdLetter;
            char fourthLetter;
            int tries;
            string guess;
            int ok;
            int badPosition;
             //message de bienvenue
            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Couleurs possibles: GYWRBMC");
            Console.WriteLine("Devine le code en 4 couleurs. \n");

            //génère la suite à deviner aléatoirement
            Random random = new Random();
            int x1 = random.Next(7);
            int x2 = random.Next(7);
            int x3 = random.Next(7);
            int x4 = random.Next(7);
            //traduit le chiffre obtenu aléatoirement en lettre afin d'avoir la première, deuxième, troisième et quatrième position du code à deviner
            switch (x1)
            {
                case 0:
                    firstLetter = 'C';
                    break;
                case 1:
                    firstLetter = 'G';
                    break;
                case 2:
                    firstLetter = 'Y';
                    break;
                case 3:
                    firstLetter = 'W';
                    break;
                case 4:
                    firstLetter = 'R';
                    break;
                case 5:
                    firstLetter = 'B';
                    break;
                case 6:
                    firstLetter = 'M';
                    break;
            }
            switch (x2)
            {
                case 0:
                    firstLetter = 'C';
                    break;
                case 1:
                    firstLetter = 'G';
                    break;
                case 2:
                    firstLetter = 'Y';
                    break;
                case 3:
                    firstLetter = 'W';
                    break;
                case 4:
                    firstLetter = 'R';
                    break;
                case 5:
                    firstLetter = 'B';
                    break;
                case 6:
                    firstLetter = 'M';
                    break;

            }
            switch (x3)
            {
                case 0:
                    firstLetter = 'C';
                    break;
                case 1:
                    firstLetter = 'G';
                    break;
                case 2:
                    firstLetter = 'Y';
                    break;
                case 3:
                    firstLetter = 'W';
                    break;
                case 4:
                    firstLetter = 'R';
                    break;
                case 5:
                    firstLetter = 'B';
                    break;
                case 6:
                    firstLetter = 'M';
                    break;
            }
            switch (x4)
            {
                case 0:
                    firstLetter = 'C';
                    break;
                case 1:
                    firstLetter = 'G';
                    break;
                case 2:
                    firstLetter = 'Y';
                    break;
                case 3:
                    firstLetter = 'W';
                    break;
                case 4:
                    firstLetter = 'R';
                    break;
                case 5:
                    firstLetter = 'B';
                    break;
                case 6:
                    firstLetter = 'M';
                    break;

            }



            //le joueur rentre une suite et la console compare avec la suite à deviner et lui répond ensuite si c'est juste ou faux
            for (tries = 1; tries < 11; ++tries)
            {
                Console.Write("Essai " + tries + ": ");
                guess = Console.ReadLine();

                if (String.Equals(goal, guess))
                {
                    Console.WriteLine("Bravo, tu as deviné en " + tries + " essai(s) !");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Dommage, c'est faux :( \n");
                }
            }
        }
    }
}
