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
            int[] Bite = new int[8];
            int[] previusBite = new int[8];
            bool problem = true;

            mesOutils.setBit(ref Bite);

            for (int i = 0; i < Bite.Length; i++)
            {
                previusBite[i] = Bite[i];
            }


            while (restart)
            {
                Console.Clear();
                string choix = "";
                problem = true;

                for (int i = 0; i < Bite.Length; i++)
                {
                    if (Bite[i] != previusBite[i])
                    {
                        couleur.red();
                        Console.Write(Bite[i]);
                    }
                    else
                    {
                        couleur.white();
                        Console.Write(Bite[i]);
                    }
                }

                while (problem)
                {

                    couleur.yellow();
                    Console.WriteLine("\n\n\nque voulez-vous faire ?\n\n");
                    couleur.cyan();
                    Console.WriteLine( "0 : revertBite\n\n" +
                                       "1 : BiteSet\n\n" +
                                       "2 : BiteClear\n\n" +
                                       "3 : BiteChange\n\n" +
                                       "4 : SetValBite\n\n" +
                                       "5 : DecalageDroite\n\n" +
                                       "6 : DecalageGauche\n\n" +
                                       "7 : BiteRang\n\n" +
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
                        Console.WriteLine("\nEntrée invalide. Veuillez entrer un place entre 0 et 9 ou la lettre Q.\n\n\n");
                    }
                }
                Console.Clear();




                //actionnement des fonctions en fonction du choix de l'utilisateur
                if (choix == "0")
                {
                    for (int i = 0; i < Bite.Length; i++)
                    {
                        Bite[i] = previusBite[i];
                    }
                }
                else if (choix == "q")
                {
                    restart = false;
                }
                else
                {

                    //changement de previusBite pour qu'il stocke le nouveau byte

                    for (int i = 0; i < Bite.Length; i++)
                    {
                        previusBite[i] = Bite[i];
                    }

                    //changer un bit en 1 dans le byte
                    if (choix == "1")
                    {
                        bool placeOK = false;
                        string input = null;
                        int place = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place > 0 && place <= 8)
                                {
                                    placeOK = true;
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 1 et 8\n\n");
                            }

                        }
                        place--;
                        mesOutils.bitSet(place, ref Bite);
                    }
                    //changer un bit en 0 dans le byte
                    else if (choix == "2")
                    {
                        bool placeOK = false;
                        string input = null;
                        int place = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place > 0 && place <= 8)
                                {
                                    placeOK = true;
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 1 et 8\n\n");
                            }

                        }
                        place--;
                        mesOutils.bitClear(place, ref Bite);
                    }
                    //flip la valeur d'un bit dans le byte
                    else if (choix == "3")
                    {
                        bool placeOK = false;
                        bool valeurOK = false;
                        string input = null;
                        int place = 0;
                        int valeur = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();
                            Console.Clear();

                            if (int.TryParse(input, out place))
                            {
                                if (place > 0 && place <= 8)
                                {
                                    placeOK = true;
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 1 et 8\n\n");
                            }
                            Console.Clear();

                            place--;
                            mesOutils.bitChange(place, ref Bite);

                        }
                    }
                    //changer un bit en 1 ou 0 en fonction de l'utilisateur dans le byte
                    else if (choix == "4")
                    {
                        bool placeOK = false;
                        bool valeurOK = false;
                        string input = null;
                        int place = 0;
                        int valeur = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();
                            Console.Clear();

                            if (int.TryParse(input, out place))
                            {
                                if (place > 0 && place <= 8)
                                {
                                    placeOK = true;
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 1 et 8\n\n");
                            }

                        }
                        Console.Clear();
                        //demande de la valeur à modifier et vérification de l'entrée utilisateur
                        while (valeurOK == false)
                        {
                            couleur.yellow();
                            Console.WriteLine("à quelle valeur voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();
                            Console.Clear();

                            if (int.TryParse(input, out valeur))
                            {
                                if (valeur == 0 || valeur == 1)
                                {
                                    valeurOK = true;
                                }
                            }

                            if (valeurOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 1\n\n");
                            }
                        }
                        Console.Clear();

                        place--;
                        mesOutils.setValBit(place, valeur, ref Bite);

                    }
                    else if (choix == "5")
                    {

                    }
                }
            }
            couleur.black();
            Console.Clear();
        }
    }
}
