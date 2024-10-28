using _5T24_PetitSolune_enigma;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Spectre.Console;

namespace _5TTI_PetitSolune_doubleursExercice9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ColorChanger couleur = new ColorChanger();
            fonctions mesOutils = new fonctions();


            bool restart = true;
            int[] Bite = new int[8];
            int[] previusBite = new int[8];
            var table = new Table();

            mesOutils.setBit(ref Bite);

            for (int i = 0; i < Bite.Length; i++)
            {
                previusBite[i] = Bite[i];
            }


            while (restart)
            {
                Console.Clear();

                var choix = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[yellow]veuillez choisir ce que vous voulez faire[/][grey] enter pour confirmer votre choix [/]")
                    .PageSize(13)
                    .AddChoices(new[] {
                        "view Byte", "redo", "bitSet","bitClear","bitChange","SetValBit","moveRight", "quit"
                }));
                Console.Clear();




                //actionnement des fonctions en fonction du choix de l'utilisateur

                if (choix == "view Byte")
                {

                    mesOutils.renderBit(Bite, ref table);
                    
                    AnsiConsole.Write(table);
                    Console.ReadKey();
                }
                //test pour savoir si l'utilisateur veux annuler sa dernière action
                else if (choix == "redo")
                {
                    for (int i = 0; i < Bite.Length; i++)
                    {
                        Bite[i] = previusBite[i];
                    }
                }
                //test pour savoir si l'utilisateur veux quitter le programme
                else if (choix == "quit")
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
                        string input = null;
                        int place = 0;

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
                        }
                        
                        place--;
                        mesOutils.bitChange(place, ref Bite);
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
                    //décaler de x places vers la droite les bits du byte
                    else if (choix == "5")
                    {
                        bool inputOK = false;
                        string input = null;
                        int nbrDecalage = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (inputOK == false)
                        {
                            couleur.yellow();
                            Console.WriteLine("à quelle place voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();
                            Console.Clear();

                            if (int.TryParse(input, out nbrDecalage))
                            {
                                if (nbrDecalage > 0)
                                {
                                    inputOK = true;
                                }
                            }

                            if (inputOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 1 et 8\n\n");
                            }
                        }
                        Console.Clear();

                        mesOutils.moveRight(nbrDecalage, ref Bite);
                    }
                }
                Console.Clear();
            }
            couleur.black();
        }
    }
}
