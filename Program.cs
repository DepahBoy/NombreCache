/**
 * name : Jeu du nombre caché
 * author : FullStack TechBoy
 * Date : 10/01/2024
 */


using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {


            // Déclaration de variables
            int valeur;
            int essai;
            int nombreEssai = 1;

            // Saisie du nombre à chercher
            Console.Write("Entrer un nombre :  ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();

            // Saisie du premier essai
            Console.Write("Entrez un premier essaie :  ");
            essai = int.Parse(Console.ReadLine());

            // Boucle while
            while (essai != valeur)
            {

                // Tester essai par rapport à la valeur rechercher
                if (essai > valeur)
                {
                    Console.WriteLine("-- > Trop grand!!!");
                }
                else
                {
                    Console.WriteLine(" -- > Trop petit!!!");
                }

                // Saisi d'un nouvel essai
                Console.Write("Entrez un nouvel essaie :  ");
                essai = int.Parse(Console.ReadLine());

                // Compteur d'essai
                nombreEssai++;
            }

            // Valeur trouvée
            Console.WriteLine("Bravos vous avez trouvé en " +nombreEssai+ " essais!!!");
            Console.WriteLine("Fin du Jeu!");

            Console.ReadLine();
        }
    }
}
