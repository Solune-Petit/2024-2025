using _5T24_PetitSolune_enigma;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5TTI_PetitSolune_doubleursExercice9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ColorChanger couleur = new ColorChanger();
            fonctions mesOutils = new fonctions();

            couleur.blue();
            Console.WriteLine("Bienvenue dans mon projet sur l'exercice 9 !!!\n\n");


            bool restart = true;
            ConsoleKeyInfo touche;
            string message = "";
            int[] bit = new int[8];
            int[] previusBit = new int[8];
            bool problem = true;

            mesOutils.setBit(ref bit);

            previusBit = bit;


            while (restart)
            {
                Console.Clear();
                string choix = "";
                problem = false;

                for (int i = 0; i < bit.Length; i++)
                {
                    if (bit[i] != previusBit[i])
                    {
                        couleur.red();
                        Console.Write(bit[i]);
                    }
                    else
                    {
                        couleur.white();
                        Console.Write(bit[i]);
                    }
                }

                while (!problem)
                {

                    couleur.yellow();
                    Console.WriteLine("\n\n\nque voulez-vous faire ?\n\n");
                    couleur.cyan();
                    Console.WriteLine( "0 : revertBit\n\n" +
                                       "1 : bitSet\n\n" +
                                       "2 : bitClear\n\n" +
                                       "3 : bitChange\n\n" +
                                       "4 : SetValBit\n\n" +
                                       "5 : DecalageDroite\n\n" +
                                       "6 : DecalageGauche\n\n" +
                                       "7 : BitRang\n\n" +
                                       "8 : RotateLeft\n\n" +
                                       "9 : RotateRight\n\n" +
                                       "Q : quitter le programme");
                    couleur.white();
                    touche = Console.ReadKey();

                    // Vérifier si l'entrée est un chiffre entre 1 et 9
                    if ((touche.KeyChar >= '0' && touche.KeyChar <= '9') || touche.KeyChar == 'q')
                    {
                        choix = touche.KeyChar.ToString();
                        problem = false;
                    }
                    else
                    {
                        Console.Clear();
                        couleur.red();
                        Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre entre 0 et 9 ou la lettre Q.\n\n\n");
                    }
                }
                Console.Clear();



                //actionnement des fonctions en fonction du choix de l'utilisateur
                if (choix == "0")
                {
                    bit = previusBit;
                }else if (choix == "q")
                {
                    restart = false;
                }
                else
                {
                    if (choix == "1")
                    {
                        bool nombreOK = false;
                        string input = null;

                        while (nombreOK == false)
                        {
                            Console.Clear();
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre bit?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out int nombre))
                            {
                                nombreOK = true;
                            }

                            mesOutils.bitSet(nombre, ref bit);
                        }
                    }
                }
            }
            Console.Clear();
        }
    }
}
