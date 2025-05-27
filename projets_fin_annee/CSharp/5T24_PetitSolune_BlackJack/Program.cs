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


                
                //choisir si on veux juste regarder les cartes ou jouer au jeu
                do
                {

                    Console.WriteLine("Bienvenu sur mon Jeu de Black Jack!\n" +
                        "Actuellement, vous vous trouvez sur le menu qui permet de choisir entre la zone de test ou le jeu.\n" +
                        "Voulez vous jouer au jeu (Y)ou aller dans la zone de test ?(N)");
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
                            Console.WriteLine("What number of card would you like (0 = ace | )?");
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
                    ConsoleKey tempInput;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("connaissez vous les rêgles (Y/N)?");
                        tempInput = Console.ReadKey().Key;
                    } while (tempInput != ConsoleKey.Y && tempInput != ConsoleKey.N);

                    if (tempInput == ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.WriteLine("Le Blackjack est un jeu de cartes dont l'objectif principal est de battre le croupier.\n" +
                            "Pour ce faire, les joueurs doivent constituer une main dont la valeur est la plus proche de 21 sans jamais le dépasser.\n\n" +
                            "Dans le jeu, les cartes ont des valeurs spécifiques :\n" +
                            "-  Les cartes numérotées de 2 à 10 (le 10 = 0) conservent leur valeur\n" +
                            "-  les figures (Valet, Dame, Roi) valent 10.\n" +
                            "-  L'As, quant à lui, peut valoir soit 1 soit 11, selon ce qui est le plus avantageux pour le joueur.\n\n\n" +
                            "Le déroulement d'une partie commence par la mise initiale, où chaque joueur place sa mise.\n\n" +
                            "Ensuite, chaque joueur reçoit deux cartes visibles, tandis que le croupier reçoit une carte visible et une autre cachée.\n\n" +
                            "À ce stade, les joueurs ont plusieurs options :\n" +
                            "HIT :          tirer une carte supplémentaire\n" +
                            "STAND :        rester avec votre main actuelle\n" +
                            "DOUBLE DOWN :  doubler votre mise et prendre une carte en plus mais vous ne pourrez plus jouer\n" +
                            "SPLIT :        séparer deux cartes de même valeur en deux mains distinctes\n\n\n" +
                            "Une fois que tous les joueurs ont terminé leur tour, le croupier révèle sa carte cachée.\n" +
                            "Selon les règles de la maison, il doit tirer des cartes jusqu'à atteindre au moins 17.\n\n" +
                            "Pour ce projet, la maison (moi) donneras comme valeur max le 19 (demandez pas pourquoi, j’aime ce chiffre :D)\n\n" +
                            "Les conditions de victoire sont simples :\n" +
                            "-  Si un joueur obtient un Blackjack (un As et une carte de 10 en première main), il remporte 1,5 fois sa mise.\n" +
                            "-  Si sa main est plus proche de 21 que celle du croupier, il gagne sa mise.\n" +
                            "-  Si le croupier dépasse 21, tous les joueurs restants gagnent.\n" +
                            "-  Cependant, si un joueur dépasse lui-même 21, il perd automatiquement sa mise.\n" +
                            "-  En cas d'égalité entre le joueur et le croupier, la mise est restituée au joueur.\n\n\n" +
                            "pour sortir de ce menu, appuiez sur n'importe quelle touche");
                        Console.ReadKey();
                    }
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("combien de joueurs êtes vous ? (max 8)");
                        tempInput = Console.ReadKey().Key;
                        Console.Clear();
                    }while (tempInput != ConsoleKey.D1 && tempInput != ConsoleKey.NumPad1 && tempInput != ConsoleKey.D2 && tempInput != ConsoleKey.NumPad2 && tempInput != ConsoleKey.D3 && 
                    tempInput != ConsoleKey.NumPad3 && tempInput != ConsoleKey.D4 && tempInput != ConsoleKey.NumPad4 && tempInput != ConsoleKey.D5 && tempInput != ConsoleKey.NumPad5 && 
                    tempInput != ConsoleKey.D6 && tempInput != ConsoleKey.NumPad6 && tempInput != ConsoleKey.D7 && tempInput != ConsoleKey.NumPad7 && tempInput != ConsoleKey.D8 && tempInput != ConsoleKey.NumPad8);

                    int nbPlayers = int.Parse(getKey.convertKey(tempInput)) + 1;


                    ////////le jeu en lui même

                    //////assignation des variables

                    //bool
                    bool restart = true;                                    //permet de recommencer une partie


                    //int
                    int timeToShuffle = 0;                                  //temps avant de mélanger le deck


                    //int[]
                    int[] handDealer = new int[11];                         //main du dealer
                    int[] shuffledDeck =                                    //variable pour l'ordre des cartes
                    {
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                    13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
                    25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
                    37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51
                    };


                    //int[][]
                    int[,] players = new int[nbPlayers,11];               //gestions des mains différents joueurs


                    //double
                    double tempMoney = 0;                                   //argent du joueur


                    //double[]
                    double[] playerMoney = new double[nbPlayers];           //argent que le joueur a


                    //string
                    string tempInputMoney = "";                             //variable temporaire


                    //string[]
                    string[] blancCard =                                    //carte blanche
                    {" ------- ","|       |","|       |","|       |","|       |","|       |"," ------- "};


                    //ConsoleKey
                    ConsoleKey askRestart;                                  //demande si le joueur veut recommencer
                    ConsoleKey uInput = ConsoleKey.Z;                       //entrée utilisateur




                    //demande l'argent que les joueurs ammènent sur la table
                    for (int i = 0; i < nbPlayers; i++)
                    {
                        do
                        {
                            Console.WriteLine("Joueur " + (i + 1) + ", avec combien d'argent venez-vous sur la table ?");
                            tempInputMoney = Console.ReadLine();
                            Console.Clear();
                        } while (!double.TryParse(tempInputMoney, out tempMoney));

                        playerMoney[i] = tempMoney;
                    }


                    outils.shuffleDeck(ref shuffledDeck);

                    int[] bet = new int[nbPlayers];
                    int tempBet;

                    Console.Clear();
                    do //déroulement de la partie
                    {
                        for (int i = 0; i < nbPlayers; i++)
                        {
                        

                            Console.Clear();
                            if (playerMoney[i] > 0)
                            {
                                do
                                {
                                    do
                                    {
                                        Console.WriteLine("Joueur " + (i + 1) + ", combien voulez vous miser ? vous avez : " + playerMoney[i]);
                                    } while (!int.TryParse(Console.ReadLine(), out tempBet));
                                } while (tempBet > playerMoney[i] && tempBet != 0);
                                bet[i] = tempBet;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Joueur " + (i + 1) + ", vous n'avez pas assez d'argent. Revenez quand vous êtes plus riches");
                                Console.ReadKey();
                            }
                        }

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



                        

                        int placeCardSpot = 0;


                        //distribution des cartes
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < nbPlayers; j++)
                            {
                                players[j,i] = shuffledDeck[placeCardSpot];
                                placeCardSpot++;
                            }
                            handDealer[i] = shuffledDeck[placeCardSpot];
                            placeCardSpot++;
                        }

                        int tempHandDealer = handDealer[1];

                        for (int i = 2; i < 11; i++)
                        {
                            for (int j = 0; j < nbPlayers; j++)
                            {
                                players[j, i] = -1;
                            }
                        }

                        for (int i = 2; i < 11; i++)
                        {
                            handDealer[i] = -1;
                        }


                        for (int i = 0; i < placeCardSpot; i++)
                        {
                            outils.rearangeDeck(ref shuffledDeck);
                        }


                        int[] playerPlaceSpot = new int[nbPlayers];

                        for (int i = 0; i < nbPlayers; i++)
                        {
                            playerPlaceSpot[i] = 2;
                        }


                        int[] playersPoints = new int[nbPlayers];
                        int dealerPoints = 0;
                        bool isDealerTurn = false;
                        bool doubleDown = false;
                        int[] playerCardSpot = new int[nbPlayers];
                        
                        for (int i = 0; i < nbPlayers; i++)
                        {
                            playerCardSpot[i] = 2;
                        }


                        //round player
                        for (int playerTurn = 0; playerTurn < nbPlayers; playerTurn++)
                        {
                            endRound = false;

                            do
                            {
                                outils.countPoints(Deck, playerTurn, nbPlayers, ref playersPoints, playerPlaceSpot, players);

                                if (playersPoints[playerTurn] < 21)
                                {

                                    //action du joueur
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine(outils.playerInterface(Deck, players, handDealer, isDealerTurn, blancCard, playersPoints, endRound, dealerPoints, playerTurn, nbPlayers));
                                        uInput = Console.ReadKey().Key;
                                    } while (uInput != ConsoleKey.Enter && uInput != ConsoleKey.Multiply && (uInput != ConsoleKey.Subtract && uInput != ConsoleKey.OemMinus));

                                    Console.Clear();

                                    //hit
                                    if (uInput == ConsoleKey.Enter)
                                    {
                                        players[playerTurn, playerPlaceSpot[playerTurn]] = shuffledDeck[0];
                                        outils.rearangeDeck(ref shuffledDeck);
                                        playerPlaceSpot[playerTurn]++;
                                    }
                                    //stand
                                    else if (uInput == ConsoleKey.Subtract)
                                    {
                                        endRound = true;
                                    }
                                    //double down
                                    else if (uInput == ConsoleKey.Multiply)
                                    {
                                        //vérifie si le joueur à assez d'argent
                                        if (playerMoney[playerTurn] >= bet[playerTurn] * 2)
                                        {
                                            players[placeCardSpot, playerTurn] = shuffledDeck[0];
                                            outils.rearangeDeck(ref shuffledDeck);
                                            endRound = true;
                                            doubleDown = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("vous n'avez pas assez pour double down !");
                                        }
                                    }
                                }
                                else if (playersPoints[playerTurn] == 21)
                                {
                                    endRound = true;
                                    Console.WriteLine(outils.playerInterface(Deck, players, handDealer, isDealerTurn, blancCard, playersPoints, endRound, dealerPoints, playerTurn, nbPlayers));
                                    uInput = Console.ReadKey().Key;
                                }
                                else
                                {
                                    endRound = true;
                                    Console.WriteLine(outils.playerInterface(Deck, players, handDealer, isDealerTurn, blancCard, playersPoints, endRound, dealerPoints, playerTurn, nbPlayers));
                                    uInput = Console.ReadKey().Key;
                                }
                            } while (endRound != true);
                        }


                        isDealerTurn = true;
                        handDealer[1] = tempHandDealer;
                        placeCardSpot = 2;



                        //round dealer
                        do
                        {
                            endRound = false;
                            //counter les points du dealer
                            dealerPoints = 0;
                            for (int i = 0; i < placeCardSpot; i++)
                            {
                                dealerPoints += int.Parse(Deck.Cards[handDealer[i]].Points);
                            }
                            //affichage du dealer
                            Console.Clear();
                            Console.WriteLine(outils.playerInterface(Deck, players, handDealer, isDealerTurn, blancCard, playersPoints, endRound, dealerPoints, 0, nbPlayers));
                            Thread.Sleep(1000);
                            if (dealerPoints < 19)
                            {
                                //ajouter une carte à la main du dealer
                                handDealer[placeCardSpot] = shuffledDeck[0];
                                outils.rearangeDeck(ref shuffledDeck);
                                placeCardSpot++;
                            }
                            else
                            {
                                endRound = true;
                            }
                        } while (!endRound);


                        //réflexion des prix

                        for (int i = 0; i < nbPlayers; i++)
                        {


                            if (dealerPoints > playersPoints[i] && dealerPoints < 21 || playersPoints[i] > 21)
                            {
                                Console.WriteLine("le dealer à gagné contre le joueur " + (i+1));
                                playerMoney[i] -= bet[i];
                            }
                            else if (dealerPoints < playersPoints[i] || dealerPoints > 21)
                            {
                                Console.WriteLine("Joueur " + (i+1) + "vous avez gagné");

                                if (doubleDown)
                                {
                                    playerMoney[i] += bet[i] * 2;
                                }
                                else
                                {
                                    playerMoney[i] += bet[i];
                                }
                                if (playersPoints[i] == 21)
                                {
                                    playerMoney[i] += bet[i] * 1.5;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Joueur " + (i+1) + ", Egalité. votre somme à été restoré dans votre banque.");
                            }
                        }


                        Console.WriteLine("\n\nvoulez vous rejouer une partie ? (Y/N) les joueurs ont :");
                        for (int i = 0; i < nbPlayers; i++)
                        {
                            Console.WriteLine("le joueur " + (i + 1) + " à : " + playerMoney[i] + " €");
                        }

                    } while ((Console.ReadKey().Key != ConsoleKey.N) && playerMoney[0] > 0);
                }
            }
        }
    }
}