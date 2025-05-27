using _5T24_PetitSolune_BlackJack.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5T24_PetitSolune_BlackJack
{
    // Définis un namespace pour ton fichier Function.cs
    class Function
    {
        //liste pour les possibles entrées utilisateurs
        ConsoleKey[] listCards = { ConsoleKey.A, ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.D7, ConsoleKey.D8, ConsoleKey.D9, ConsoleKey.V, ConsoleKey.D, ConsoleKey.R };
        ConsoleKey[] listSymbole = { ConsoleKey.D, ConsoleKey.S, ConsoleKey.C, ConsoleKey.H };

        public int getCardValue(int Number, ConsoleKey keySymbol)
        {
            //gets the card value from table
            for (int i = 0; i < listSymbole.Length; i++)
            {
                if (keySymbol == listSymbole[i])
                {
                    Number = Number + (i * 13);
                }
            }
            return Number;
        }

        public string playerInterface(deck Deck, int[,] handPlayer, int[] handDealer, bool isDealerTurn, string[] blancCard, int[] points, bool endRound, int dealerPoints, int turnPlayer, int nbPlayer)
        {
            string output = "";

            string[][] cardTable = new string[(11 * nbPlayer) + 2][];

            string[] space =
            {
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       "
            };

            if (!isDealerTurn)
            {

                output += "             Joueur " + (turnPlayer + 1) + ", c'est à vous de jouer !\n\n\n\n";

                output += "Dealer :\n           ";

                cardTable[0] = Deck.Cards[handDealer[0]].Image.Split("\r\n");
                cardTable[1] = blancCard;


                //permet de faire en sorte d'écrire les cartes du dealer côtes à côtes

                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < cardTable.Length; i++)
                    {
                        if(cardTable[i] != null)
                        {
                            output += cardTable[i][j] + " ";
                        }
                    }
                    output += "\n           ";
                }
                if (!endRound)
                {
                    output += "\n" +
                        "voici vos options :\n" +
                        "-  Hit         (enter)\n" +
                        "-  Stand       (-)\n" +
                        "-  Double Down (*)\n\n\n";
                }
                else
                {
                    output += "\n" +
                        "voici vos options :\n" +
                        "vous ne pouvez plus jouer\n" +
                        "pour passer à l'étappe suivante, appuiez sur n'importe quelle touche\n\n\n";
                }

                output += "Players :\n           ";

                int temp = 0;

                for (int i = 0; i < handPlayer.GetLength(0); i++)
                {
                    for(int j = 0; j < handPlayer.GetLength(1); j++)
                    {
                        if (handPlayer[i, j] != -1)
                        {
                            cardTable[temp] = Deck.Cards[handPlayer[i, j]].Image.Split("\r\n");
                            temp++;
                        }

                        if (j == 10)
                        {
                            cardTable[temp] = space;
                            temp++;
                        }
                    }
                }

                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < cardTable.Length; i++)
                    {
                        if (cardTable[i] != null)
                        {
                            output += cardTable[i][j] + " ";
                        }
                    }
                    output += "\n           ";
                }

                output += "\n\n\n";

                for (int i = 0; i < handPlayer.GetLength(0); i++)
                {
                    output += "Joueur " + (i+1) + ", vous avez " + points[i] + " points \n";
                }
            }
            else
            {
                //affichage tour dealer
                output = "Dealer :\n           ";

                for (int i = 0; i < handDealer.Length; i++)
                {
                    if (handDealer[i] != -1)
                    {
                        cardTable[i] = Deck.Cards[handDealer[i]].Image.Split("\r\n");
                    }
                }


                //permet de faire en sorte d'écrire les cartes du dealer côtes à côtes

                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < cardTable.Length; i++)
                    {
                        if (cardTable[i] != null)
                        {
                            output += cardTable[i][j] + " ";
                        }
                    }
                    output += "\n           ";
                }

                output += "le dealer à "+ dealerPoints +" points\n\n\n\n\n\n";

                cardTable = new string[11][];

                output += "Players :\n           ";

                int temp = 0;

                for (int i = 0; i < handPlayer.GetLength(0); i++)
                {
                    for (int j = 0; j < handPlayer.GetLength(1); j++)
                    {
                        if (handPlayer[i, j] != -1)
                        {
                            cardTable[temp] = Deck.Cards[handPlayer[i, j]].Image.Split("\r\n");
                            temp++;
                        }

                        if (j == 10)
                        {
                            cardTable[temp] = space;
                            temp++;
                        }
                    }
                }

                for (int j = 0; j < 7; j++)
                {
                    for (int i = 0; i < cardTable.Length; i++)
                    {
                        if (cardTable[i] != null)
                        {
                            output += cardTable[i][j] + " ";
                        }
                    }
                    output += "\n           ";
                }

                output += "\n\n\n";

                for (int i = 0; i < handPlayer.GetLength(0); i++)
                {
                    output += "Joueur " + (i + 1) + ", vous avez " + points[i] + " points \n";
                }
            }


            return output;
        }

        public void shuffleDeck(ref int[] shuffledDeck)
        {
            //mélange le deck
            Random rnd = new Random();
            int n = shuffledDeck.Length;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                int value = shuffledDeck[k];
                shuffledDeck[k] = shuffledDeck[n];
                shuffledDeck[n] = value;
            }
        }

        public void rearangeDeck(ref int[] shuffledDeck)
        {
            //fait tourner le deck
            int temp = shuffledDeck[0];
            for (int i = 0; i < shuffledDeck.Length - 1; i++)
            {
                shuffledDeck[i] = shuffledDeck[i + 1];
            }
            shuffledDeck[shuffledDeck.Length - 1] = temp;
        }

        public void countPoints(deck Deck,int playerTurn, int nbPlayers, ref int[] playersPoints, int[] playerPlaceSpot, int[,] players)
        {
            int[] tempCards = new int[2];
            int[] counter = new int[nbPlayers];

            playersPoints = new int[nbPlayers];

            for (int i = 0; i < nbPlayers; i++)
            {
                for (int j = 0; j < playerPlaceSpot[i]; j++)
                {
                    if (int.Parse(Deck.Cards[players[i, j]].Points) == 1)
                    {
                        tempCards[counter[i]] = players[i, j];
                        counter[i]++;
                    }
                    else
                    {
                        playersPoints[i] += int.Parse(Deck.Cards[players[i, j]].Points);
                    }
                }
            }


            for (int i = 0; i < playersPoints.Length; i++)
            {
                for (int j = 0; j < counter[i]; j++)
                {
                    int pointTemp = playersPoints[i] + 11;

                    if (pointTemp <= 21)
                    {
                        playersPoints[i] += 11;
                    }
                    else
                    {
                        playersPoints[i] += 1;
                    }
                }
            }
        }
    }
}
