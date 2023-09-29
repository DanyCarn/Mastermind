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
        /// Description : Jeu mastermind où la console génère un code aléatoire que l'utilisateur doit deviner grâce aux indices de la console, couleur bien placée ou pas au bon emplacement
        /// Auteur      : Dany Carneiro
        /// Date        : 01.09.2023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] goal = new char[4];
            char[] guessArray = new char[4];
            int tries;
            string guess;
            int ok = 0;
            int badPosition = 0;
            bool quit = false;
            bool goodLenght = false;
             //message de bienvenue
            Console.WriteLine("Bienvenue sur Mastermind!");
            do
            {
                Console.WriteLine("Couleurs possibles: GYWRBMC");
                Console.WriteLine("Devine le code en 4 couleurs. \n");
                //génère la suite à deviner aléatoirement
                Random random = new Random();
                int number1 = random.Next(6);
                int number2 = random.Next(6);
                int number3 = random.Next(6);
                int number4 = random.Next(6);
                //traduit le chiffre obtenu aléatoirement en lettre afin d'avoir la première, deuxième, troisième et quatrième position du code à deviner
                switch (number1)
                {
                    case 0:
                        goal[0] = 'C';
                        break;
                    case 1:
                        goal[0] = 'G';
                        break;
                    case 2:
                        goal[0] = 'Y';
                        break;
                    case 3:
                        goal[0] = 'W';
                        break;
                    case 4:
                        goal[0] = 'R';
                        break;
                    case 5:
                        goal[0] = 'B';
                        break;
                    case 6:
                        goal[0] = 'M';
                        break;
                }
                switch (number2)
                {
                    case 0:
                        goal[1] = 'C';
                        break;
                    case 1:
                        goal[1] = 'G';
                        break;
                    case 2:
                        goal[1] = 'Y';
                        break;
                    case 3:
                        goal[1] = 'W';
                        break;
                    case 4:
                        goal[1] = 'R';
                        break;
                    case 5:
                        goal[1] = 'B';
                        break;
                    case 6:
                        goal[1] = 'M';
                        break;
                }
                switch (number3)
                {
                    case 0:
                        goal[2] = 'C';
                        break;
                    case 1:
                        goal[2] = 'G';
                        break;
                    case 2:
                        goal[2] = 'Y';
                        break;
                    case 3:
                        goal[2] = 'W';
                        break;
                    case 4:
                        goal[2] = 'R';
                        break;
                    case 5:
                        goal[2] = 'B';
                        break;
                    case 6:
                        goal[2] = 'M';
                        break;
                }
                switch (number4)
                {
                    case 0:
                        goal[3] = 'C';
                        break;
                    case 1:
                        goal[3] = 'G';
                        break;
                    case 2:
                        goal[3] = 'Y';
                        break;
                    case 3:
                        goal[3] = 'W';
                        break;
                    case 4:
                        goal[3] = 'R';
                        break;
                    case 5:
                        goal[3] = 'B';
                        break;
                    case 6:
                        goal[3] = 'M';
                        break;

                }
                //le joueur rentre une suite et la console compare avec la suite à deviner et lui répond ensuite si c'est juste ou faux
                for (tries = 1; tries < 11; ++tries)
                {
                    do
                    {
                        //vérifie que ce que l'utilisateur rentre fasse la bonne longueur. Si non, demande à l'utilisateur de re-rentrer un essai
                        goodLenght = false;
                        Console.Write("Essai " + tries + ": ");
                        guess = Console.ReadLine();
                        if (guess.Length == guessArray.Length)
                            goodLenght = true;
                        else
                            Console.WriteLine("Votre essai doit faire 4 charactères");

                    } while (goodLenght == false);
                    guessArray = guess.ToCharArray();
                    ok = 0;
                    badPosition = 0;
                    Console.WriteLine(goal);

                    //La console compare l'essai de l'utilisateur et le code généré aléatoirement. Si une lettre est au bon emplacement,
                    for (int i = 0; i < 4; i++)
                    {
                            if (guessArray[i] == goal[i])
                            {
                                    ok++;
                            }
                            else
                            {
                                foreach (char j in goal)
                                {
                                    if (j == guessArray[i])
                                        badPosition++;                                    
                                }
                            }
                    }
                    //si les 4 lettres sont bonnes, le programme félicite le joueur
                    if (ok == 4)
                    {
                        Console.WriteLine("Bravo !");
                        break;
                    }
                    Console.WriteLine("=>Ok: " + ok);
                    Console.WriteLine("=>Mauvaise position: " + badPosition + "\n");
                }
                //si tous les essais sont épuisée, la console révèle le code caché
                if (tries == 11)
                {
                    Console.Write("Vous avez perdu, le code était ");
                    foreach(char item in goal)
                    {
                        Console.Write(item.ToString());
                    }
                }
                Console.WriteLine();
                //La console demande au joueur si il veut rejouer qui répondra "o" s'il souhaite rejouer et "n" s'il souhaite arrêter
                Console.WriteLine("Voulez-vous rejouer ? (o/n)");
                string restart = Console.ReadLine();
                if (restart == "n")
                    quit = true;
            }while (quit == false);
        }
    }
}
