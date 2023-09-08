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
            string goal;
            int tries = 0;
            string guess;

            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Couleurs possibles: GYWRBMC");
            Console.WriteLine("Devine le code en 4 couleurs.");
            Console.ReadLine();


            //à compléter avec un boucle
            Console.WriteLine("Essai " + tries + 1);
            guess = Console.ReadLine();


         
        }
    }
}
