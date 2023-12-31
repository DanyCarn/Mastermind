﻿using System;
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
            char[] notOk = new char[4] {'_','_','_','_'};
            int tries;
            string guess;
            int ok = 0;
            int badPosition = 0;
            bool quit = false;
            bool goodLenght = false;
            string choice;
            int number1;
            int number2;
            int number3;
            int number4;
            do {
                //message de bienvenue + choix du mode
                Console.Clear();
                Console.WriteLine("Bienvenue sur Mastermind!");
                Console.WriteLine("Choisissez votre mode de jeu");
                Console.WriteLine("1. Mode normal");
                Console.WriteLine("2. mode facile");
                Console.WriteLine("3. Quitter");
                choice = Console.ReadLine();
                //selon le choix de l'utilisateur, lance la fonction du mode correspondant
                switch(choice)
                {
                    case "1":
                        //si l'utilisateur choisi 1, le mode normal se lance
                        normalMode();
                        break;
                    case "2":
                        //si l'utilisateur choisi 2, le mode facile se lance
                        easyMode();
                        break;
                    case "3":
                        //si l'utilisateur choisi 3, le jeu s'arrête
                        quit = stopGame();
                        break;
                }
                Console.ReadLine();
                //mode normal
                void normalMode()
                {
                    Console.Clear();
                        Console.WriteLine("Couleurs possibles: GYWRBMC");
                        Console.WriteLine("Devine le code en 4 couleurs. \n");
                        //génère la suite à deviner aléatoirement
                        Random random = new Random();
                        number1 = random.Next(6);
                        number2 = random.Next(6);
                        number3 = random.Next(6);
                        number4 = random.Next(6);
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
                            //Console.Write(goal);
                            //Console.WriteLine(" (Seulement pour le test)");
                            //La console compare l'essai de l'utilisateur et le code généré aléatoirement. Si une lettre est au bon emplacement, ajoute 1 a la variable ok.
                            for (int i = 0; i < 4; i++)
                            {
                                notOk[i] = '_';
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                if (guessArray[i] == goal[i])
                                {
                                    ok++;
                                    notOk[i] = '_';
                                }
                                else
                                {

                                    for (int j = 0; j < goal.Length; j++)
                                    {
                                        if (goal[j] == guessArray[i])
                                        {
                                            if (goal[j] != guessArray[j])
                                            {
                                                notOk[i] = guessArray[i];
                                            }
                                        }
                                    } 
                                }
                            }


                            foreach (char j in notOk)
                            {
                                if (j != '_')
                                {
                                    badPosition++;
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
                            foreach (char item in goal)
                            {
                                Console.Write(item.ToString());
                            }
                        }
                        Console.WriteLine();
                        //La console informe le joeuur qu'il sera rammené au menu
                        Console.WriteLine("Vous allez être rammené(e) sur le menu");
                        Console.ReadLine();
                }
                //mode facile
                void easyMode()
                {
                        Console.Clear();
                        Console.WriteLine("Couleurs possibles: GYWRBMC");
                        Console.WriteLine("Devine le code en 4 couleurs. \n");
                        //génère la suite à deviner aléatoirement
                        Random random = new Random();
                        number1 = random.Next(6);
                        do
                        {
                            number2 = random.Next(6);
                        } while (number2 == number1);
                        do
                        {
                            number3 = random.Next(6);
                        } while (number3 == number2 || number3 == number1);
                        do
                        {
                            number4 = random.Next(6);
                        } while (number4 == number3 || number4 == number2 || number4 == number1);
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
                            char[] easyDisplay = { '_', '_', '_', '_' };
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
                            //Console.Write(goal);
                            //Console.WriteLine(" (Seulement pour le test)");
                            //La console compare l'essai de l'utilisateur et le code généré aléatoirement. Si une lettre est au bon emplacement, il la rajoute dans l'affichage.
                            for (int i = 0; i < 4; i++)
                            {
                                notOk[i] = '_';
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                if (guessArray[i] == goal[i])
                                {
                                    ok++;
                                    easyDisplay[i] = goal[i];
                                }
                                else
                                {
                                    for (int j = 0; j < goal.Length; j++)
                                    {
                                        if (goal[j] == guessArray[i])
                                        {
                                            if (goal[j] != guessArray[j])
                                            {
                                                notOk[i] = guessArray[i];
                                            }
                                            else
                                            {
                                                notOk[i] = '_';
                                            }
                                        }
                                    }

                                }
                            }
                            //place un $ si la couleur est mal placée
                            for (int i = 0; i < 4; i++)
                            {
                                if (notOk[i] != '_' && goal[i] != '_')
                                {
                                    badPosition++;
                                    easyDisplay[i] = '$';
                                }
                            }
                            //si les 4 lettres sont bonnes, le programme félicite le joueur
                            if (ok == 4)
                            {
                                Console.WriteLine("Bravo !");
                                break;
                            }
                            Console.Write("Réponse [$=bonne couleur]: ");
                            for (int i = 0; i < 4; i++)
                            {
                                switch (easyDisplay[i])
                                {
                                    case 'G':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'Y':
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'W':
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'R':
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'B':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'M':
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case 'C':
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Write(easyDisplay[i]);
                                        Console.ResetColor();
                                        break;
                                    case '$':
                                        switch (notOk[i])
                                        {
                                            case 'G':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'Y':
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'W':
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'R':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'B':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'M':
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                            case 'C':
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.Write(easyDisplay[i]);
                                                Console.ResetColor();
                                                break;
                                        }
                                        break;
                                    case '_':
                                        Console.Write(easyDisplay[i]);
                                        break;
                                }
                            }
                            Console.WriteLine("\n");
                        }
                        //si tous les essais sont épuisée, la console révèle le code caché
                        if (tries == 11)
                        {
                            Console.Write("Vous avez perdu, le code était ");
                            foreach (char item in goal)
                            {
                                Console.Write(item.ToString());
                            }
                        }
                        Console.WriteLine();
                        //La console informe le joeuur qu'il sera rammené au menu
                        Console.WriteLine("Vous allez être rammené(e) sur le menu");
                        Console.ReadLine();
                }
                //arrêter le jeu
                bool stopGame()
                {
                    return true;
                }
            } while (quit == false); 
        }
    }
}
