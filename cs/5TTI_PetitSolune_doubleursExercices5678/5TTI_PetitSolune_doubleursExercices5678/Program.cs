using _5T24_PetitSolune_enigma;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml;

namespace _5TTI_PetitSolune_doubleursExercices5678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorChanger couleur = new ColorChanger();
            fonctions mesOutils = new fonctions();

            bool restart = true;
            ConsoleKeyInfo touche;

            while (restart)
            {
                Console.Clear();
                int choix = 0;

                while (choix < 1 || choix > 4)
                {
                    couleur.blue();
                    Console.WriteLine("Bienvenue dans mon projet !!!\n\n");
                    couleur.yellow();
                    Console.WriteLine("que voulez-vous faire ?\n\n");
                    couleur.cyan();
                    Console.WriteLine("1 : savoir si un entier naturel que vous proposez est cubique ou non\n\n" +
                                        "2 : déterminer tous les chiffres qui divisent un nombre en dessous de 10000)\n\n" +
                                        "3 : trouver un nombre naturel entier entre deux valeurs que vous définissez (en construction)\n\n" +
                                        "4 : générer les x nombres premiers");
                    couleur.white();
                    touche = Console.ReadKey();

                    // Vérifier si l'entrée est un chiffre entre 1 et 4
                    if (touche.KeyChar >= '1' && touche.KeyChar <= '4')
                    {
                        choix = int.Parse(touche.KeyChar.ToString());
                    }
                    else
                    {
                        Console.Clear();
                        couleur.red();
                        Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre entre 1 et 4.\n\n\n");
                    }
                }
                Console.Clear();


                //selection des option
                if (choix == 1)
                {
                    bool nombreOK = false;
                    string input = null;

                    while (nombreOK == false)
                    {
                        Console.Clear();
                        couleur.yellow();
                        Console.WriteLine("quel nombre voulez vous tester pour savoir s'il est cubique parfait ?");
                        couleur.white();
                        input = Console.ReadLine();

                        if (int.TryParse(input, out int nombre))
                        {
                            nombreOK = true;
                        }
                    }
                    mesOutils.trouveSiCubique(input, out string message);

                    Console.WriteLine(message );
                    couleur.darkcyan();
                    Console.WriteLine("\n\n\npour passer au menu suivant, pressez n'importe quelle touche");
                    Console.ReadKey();
                }else if (choix == 2)
                {
                    int input;

                    do
                    {
                        Console.Clear();
                        couleur.yellow();
                        Console.WriteLine("saisissez un nombre positif et inférieur à 10000");
                        couleur.white();

                    } while ((int.TryParse(Console.ReadLine(), out input) == false) || input > 10000);

                    mesOutils.chiffresDiviseurs(input, out string message);
                    
                    Console.WriteLine(message);
                    couleur.darkcyan();
                    Console.WriteLine("\n\n\npour passer au menu suivant, pressez n'importe quelle touche");
                    Console.ReadKey();
                }



                //permet de recommencer
                do
                {
                    Console.Clear();
                    couleur.magenta();
                    Console.WriteLine("voulez vous continuer à utiliser le programme  ? (Y/N)");
                    couleur.black();
                    touche = Console.ReadKey();
                } while (touche.KeyChar != 'y' && touche.KeyChar != 'Y' && touche.KeyChar != 'n' && touche.KeyChar != 'N');

                if (touche.KeyChar == 'n' || touche.KeyChar == 'N')
                {
                    restart = false;
                }
            }
            Console.Clear();
        }
    }
}
