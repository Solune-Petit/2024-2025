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
                    int timeToShuffle = 0;              //temps avant de mélanger le deck


                    //string
                    string temp;                        //variable temporaire
                    string[] blancCard =                //carte blanche
                    {" ------- ","|       |","|       |","|       |","|       |","|       |"," ------- "};


                    //int[]
                    int[] handPlayer = new int[11];     //main du joueur
                    int[] handDealer = new int[11];     //main du dealer
                    int[] shuffledDeck =                //variable pour l'ordre des cartes
                    {
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                    13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
                    25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
                    37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51
                    };


                    //ConsoleKey
                    ConsoleKey askRestart;              //demande si le joueur veut recommencer
                    ConsoleKey uInput;                  //entrée utilisateur

                    //demande l'argent du joueur
                    do
                    {
                        Console.WriteLine("avec combien venez-vous sur la table ?");
                        temp = Console.ReadLine();
                        Console.Clear();
                    } while (!int.TryParse(temp, out playerMoney));


                    outils.shuffleDeck(ref shuffledDeck);


                    Console.Clear();
                    do //déroulement de la partie
                    {
                        if(playerMoney > 0)
                        {
                            //mélange des cartes
                            if (timeToShuffle == 10)
                            {
                                timeToShuffle = 0;
                                outils.shuffleDeck(ref shuffledDeck);
                            }
                            else
                            {
                                timeToShuffle++;
                            }

                            bool endRound = false;

                            int bet = 0;

                            do
                            {
                                do
                                {
                                    Console.WriteLine("combien voulez vous miser ? vous avez : " + playerMoney);
                                } while (!int.TryParse(Console.ReadLine(), out bet));
                            } while (bet >= playerMoney);
                            Console.Clear();

                            //distribution des cartes
                            handPlayer[0] = shuffledDeck[0];
                            handDealer[0] = shuffledDeck[1];
                            handPlayer[1] = shuffledDeck[2];
                            int tempHandDealer = shuffledDeck[3];

                            for(int i = 2; i < 11; i++)
                            {
                                handPlayer[i] = -1;
                            }
                            

                            for(int i = 0; i < 2; i++)
                            {
                                outils.rearangeDeck(ref shuffledDeck);
                            }



                            bool isDealerTurn = false;
                            //round player
                            do
                            {
                                Console.WriteLine(outils.playerInterface(Deck, handPlayer, handDealer, isDealerTurn, blancCard));
                                do
                                {
                                    uInput = Console.ReadKey().Key;
                                }while(uInput != ConsoleKey.Enter || uInput != ConsoleKey.Divide || uInput != ConsoleKey.Multiply || uInput != ConsoleKey.Subtract);



                            } while (!endRound);

                            isDealerTurn = true;


                        }
                        
                        Console.WriteLine("voulez vous rejouer une partie ? (Y/N) vous avez : " + playerMoney);
                    } while ((Console.ReadKey().Key != ConsoleKey.N) && playerMoney > 0);
                }
            }
        }
    }
}