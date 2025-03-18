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

        public string playerInterface()
        {
            string output = "";


            return output;
        }
    }
}
