namespace _5T24_PetitSolune_BlackJack
{
    using Deck;

    namespace _5T24_PetitSolune_BlackJack
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Function outils = new Function();
                KeyConverter getKey = new KeyConverter();

                // Créer un nouveau jeu de cartes
                deck Deck = new deck();
                

                //variables pour les entrées utilisateurs
                System.ConsoleKey keyNumber;
                System.ConsoleKey keySymbol;

                //variables pour la place de la carte choisie dans le tableau
                int Number;

                //variable pour choisir le mode du programme
                string typeOfUse = string.Empty;


                
                //choisir si on veux juste regarder les cartes où jouer au jeu
                do
                {

                    Console.WriteLine("Bienvenu sur mon Jeu de Black Jack!\nActuellement, vous vous trouvez sur le menu qui permet de choisir entre la zone de test ou le jeu.\n" +
                        "Voulez vous jouer au jeu (Y) ou aller dans la zone de test ?(N)");
                    ConsoleKey temp = Console.ReadKey().Key;
                    Console.Clear();
                    if (temp == ConsoleKey.N)
                    {
                        typeOfUse = "test";
                    }
                    else if (temp == ConsoleKey.Y)
                    {
                        typeOfUse = "game";
                    }
                    else
                    {
                        typeOfUse = string.Empty;
                    }


                } while (typeOfUse == string.Empty);



                // Afficher une carte choisie
                if (typeOfUse == "test")
                {

                    do
                    {
                        do //checks the user's inputs
                        {

                            // Get the next key press
                            Console.WriteLine("What number of card would you like ?");
                            keyNumber = Console.ReadKey().Key;
                            Console.Clear();
                            Console.WriteLine("What symbol would you like to have (D, H, S, C) ?");
                            keySymbol = Console.ReadKey().Key;
                            Console.Clear();


                            //convert key input into the desired number
                            Number = int.Parse(getKey.convertKey(keyNumber));

                            Number = outils.getCardValue(Number, keySymbol);

                            if (keySymbol == ConsoleKey.Enter)
                            {
                                Number = 0;
                            }
                            else if (Number >= 1000)
                            {
                                Console.WriteLine("veuillez entrer une carte correcte");
                            }

                        } while (Number >= 1000);




                        Console.WriteLine(Deck.Cards[Number].Image);


                    } while (keySymbol != ConsoleKey.Enter);
                    Console.Clear();

                }
                else
                {
                    ////////le jeu en lui même

                    //////assignation des variables
                    //bool
                    bool restart = true;                //permet de recommencer une partie

                    //int
                    int playerMoney = 0;                //argent que le joueur a

                    //int[]

                    int[] handPlayer = new int[11];     //main du joueur

                    //string
                    string temp = "";                        //entrée temporaire pour vérif entrées


                    //demande l'argent du joueur
                    do
                    {
                        Console.WriteLine("avec combien venez-vous sur la table ?");
                        temp = Console.ReadLine();
                        Console.Clear();
                    } while (!int.TryParse(temp, out playerMoney));

                    while (true)
                    {
                        string[][] test = new string[11][];

                        for (int i = 0; i < 11; i++)
                        {
                            temp = Console.ReadLine();
                            test[i] = Deck.Cards[int.Parse(temp)].Image.Split("\r\n");
                        }

                        for (int j = 0; j < 7; j++)
                        {
                            for (int i = 0; i < test.Length; i++)
                            {
                                Console.Write(test[i][j] + " ");
                            }
                            Console.Write("\n");
                        }
                        Console.ReadKey();
                    }


                }
            }
        }
    }
}