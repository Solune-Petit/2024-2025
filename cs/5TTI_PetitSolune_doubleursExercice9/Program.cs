using _5T24_PetitSolune_enigma;
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
            var ByteTable = new Table();
            string printByte;

            mesOutils.setBit(ref Bite);

            for (int i = 0; i < Bite.Length; i++)
            {
                previusBite[i] = Bite[i];
            }


            while (restart)
            {
                Console.Clear();

                mesOutils.renderBit(Bite, ref ByteTable);
                AnsiConsole.Write(ByteTable);

                var choix = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("\n\n\n[yellow]veuillez choisir ce que vous voulez faire[/][grey] enter pour confirmer votre choix [/]")
                    .PageSize(13)
                    .AddChoices(new[] {
                        "redo", "bitSet","bitClear","bitChange","SetValBit","moveRight", "moveLeft", "bitRang", "ROL", "quit"
                }));
                Console.Clear();




                //actionnement des fonctions en fonction du choix de l'utilisateur

                //test pour savoir si l'utilisateur veux annuler sa dernière action
                if (choix == "redo")
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
                //sortir la valeur d'un bit à une position donnée dans le byte
                else if (choix == "bitRang")
                {
                    bool placeOK = false;
                    string input = null;
                    int place = 0;

                    //demande de la place de modification et vérification de l'entrée utilisateur
                    while (placeOK == false)
                    {
                        Console.Clear();
                        AnsiConsole.Write(ByteTable);
                        couleur.yellow();
                        Console.WriteLine("à quelle rang voulez-vous voire la valeur d'un bit");
                        couleur.white();
                        input = Console.ReadLine();

                        if (int.TryParse(input, out place))
                        {
                            if (place >= 0 && place <= 7)
                            {
                                placeOK = true;
                                place = -(place - 7);
                            }
                        }

                        if (placeOK == false)
                        {
                            couleur.red();
                            Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 7\n\n");
                        }

                    }
                    Console.Clear();

                    int bitValue = mesOutils.BitRang(place, ref Bite);

                    AnsiConsole.Markup("[yellow]la valeur du bit au rang [/][blue]" + input + "[/][yellow] est [/][green]" + bitValue + "[/]");
                    Console.ReadKey();
                }
                else
                {

                    //changement de previusBite pour qu'il stocke le nouveau byte

                    for (int i = 0; i < Bite.Length; i++)
                    {
                        previusBite[i] = Bite[i];
                    }

                    //changer un bit en 1 dans le byte
                    if (choix == "bitSet")
                    {
                        bool placeOK = false;
                        string input = null;
                        int place = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("à quelle rang voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place >= 0 && place <= 7)
                                {
                                    placeOK = true;
                                    place = -(place - 7);
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 7\n\n");
                            }

                        }
                        Console.Clear();

                        mesOutils.bitSet(place, ref Bite);
                    }
                    //changer un bit en 0 dans le byte
                    else if (choix == "bitClear")
                    {
                        bool placeOK = false;
                        string input = null;
                        int place = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("à quelle rang voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place >= 0 && place <= 7)
                                {
                                    placeOK = true;
                                    place = -(place - 7);
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 7\n\n");
                            }

                        }
                        mesOutils.bitClear(place, ref Bite);
                    }
                    //flip la valeur d'un bit dans le byte
                    else if (choix == "bitChange")
                    {
                        bool placeOK = false;
                        string input = null;
                        int place = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("à quelle rang voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place >= 0 && place <= 7)
                                {
                                    placeOK = true;
                                    place = -(place - 7);
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 7\n\n");
                            }
                        }

                        mesOutils.bitChange(place, ref Bite);
                    }
                    //changer un bit en 1 ou 0 en fonction de l'utilisateur dans le byte
                    else if (choix == "SetValBit")
                    {
                        bool placeOK = false;
                        bool valeurOK = false;
                        string input = null;
                        int place = 0;
                        int valeur = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (placeOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("à quelle rang voulez-vous changer votre Bite?");
                            couleur.white();
                            input = Console.ReadLine();

                            if (int.TryParse(input, out place))
                            {
                                if (place >= 0 && place <= 7)
                                {
                                    placeOK = true;
                                    place = -(place - 7);
                                }
                            }

                            if (placeOK == false)
                            {
                                couleur.red();
                                Console.WriteLine("erreur, vous devez entre un chiffre entre 0 et 7\n\n");
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

                        mesOutils.setValBit(place, valeur, ref Bite);

                    }
                    //décaler de x places vers la droite les bits du byte
                    else if (choix == "moveRight")
                    {
                        bool inputOK = false;
                        string input = null;
                        int nbrDecalage = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (inputOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("de combien de rang voulez vous décaler votre byte ?");
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
                    //décaler de x places vers la droite les bits du byte
                    else if (choix == "moveLeft")
                    {
                        bool inputOK = false;
                        string input = null;
                        int nbrDecalage = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (inputOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("de combien de rang voulez vous décaler votre byte ?");
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

                        mesOutils.moveLeft(nbrDecalage, ref Bite);
                    }
                    //faire une rotation de x places vers la gauche
                    else if (choix == "ROL")
                    {
                        bool inputOK = false;
                        string input = null;
                        int nbrDecalage = 0;

                        //demande de la place de modification et vérification de l'entrée utilisateur
                        while (inputOK == false)
                        {
                            Console.Clear();
                            AnsiConsole.Write(ByteTable);
                            couleur.yellow();
                            Console.WriteLine("de combien de rang voulez vous faire tourner votre byte ?");
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

                        mesOutils.ROL(nbrDecalage, ref Bite);
                    }
                }
                Console.Clear();
            }
            couleur.black();
        }
    }
}
