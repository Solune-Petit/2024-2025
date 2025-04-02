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

        public string playerInterface(deck Deck, int[] handPlayer, int[] handDealer, bool isDealerTurn, string[] blancCard)
        {
            string output = "";

            string[][] cardTable = new string[11][];

            if (!isDealerTurn)
            {

                output = "Dealer :\n           ";

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

                output += "\n" +
                    "voici vos options :\n" +
                    "-  Hit         (enter)\n" +
                    "-  Stand       (-)\n" +
                    "-  Double Down (*)\n" +
                    "-  Split       (/)\n\n\n";


                output += "Player :\n           ";

                for (int i = 0; i < handPlayer.Length; i++)
                {
                    if (handPlayer[i] != -1)
                    {
                        cardTable[i] = Deck.Cards[handPlayer[i]].Image.Split("\r\n");
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
            }
            else
            {

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
    }
}
