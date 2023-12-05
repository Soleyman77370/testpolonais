using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // taille du tableau
            int taille = 5;
            //tableau des temperatures
            float[] t = new float[taille];
            // saisie des température et cumul
            float moyenne = 0;
            for (int k=0;k < taille; k++)
            {
                Console.Write("Entrez la temperature n°" + ( k + 1 ) + "=");
                t[k] = float.Parse(Console.ReadLine());

                moyenne += t[k];

            }
            //calcule de la moyenne
            moyenne = moyenne / taille;
            //calcule du nombre de température au dessus de cette moyenne
            int nbsup = 0;
            for (int k = 0; k < taille; k++)
            {
                if (t[k] > moyenne)
                {
                    nbsup++;
                }
                 
            }

            //affichage du résultat
            Console.WriteLine("Nombre de température au dessus de la moyenne =" + nbsup);

            Console.ReadLine();

        }
    }
}
