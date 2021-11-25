using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauExercice2_Cor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisie de la dimension (taille) du tableau 
            Console.Write("Quelle est la dimension du tableau : ");
            int dimension = int.Parse(Console.ReadLine());

            // Déclaration du tableau
            float[] temperatures = new float[dimension];

            // Saisie des temperatures
            for (int i = 0; i < dimension; i++)
            {
                Console.Write("Entrez une température  : ");
                temperatures[i] = float.Parse(Console.ReadLine());
            }

            // Recherche d'une temperature
            bool trouve = false;
            int indice = 0;

            Console.Write("Quelle température recherchez-vous ? : ");
            float valeur = int.Parse(Console.ReadLine());

            for (int i = 0; i < dimension; i++)
            {
                if (temperatures[i] == valeur)
                {
                    trouve = true;
                    indice = i;
                }
            }
            if (trouve == true)
            {
                Console.WriteLine($"La température {valeur} été trouvée à l'indice {indice}.");
            }
            else
            {
                Console.WriteLine($"La température {valeur} n'a pas été trouvée.");
            }
            Console.ReadLine();
        }
    }
}
