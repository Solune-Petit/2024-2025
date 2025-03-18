using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_PetitSolune_BlackJack
{
    class KeyConverter
    {
        public string convertKey(ConsoleKey key)
        {
            if (key == ConsoleKey.A || key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                return "0";
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                return "1";
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                return "2";
            }
            else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                return "3";
            }
            else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
            {
                return "4";
            }
            else if (key == ConsoleKey.D6 || key == ConsoleKey.NumPad6)
            {
                return "5";
            }
            else if (key == ConsoleKey.D7 || key == ConsoleKey.NumPad7)
            {
                return "6";
            }
            else if (key == ConsoleKey.D8 || key == ConsoleKey.NumPad8)
            {
                return "7";
            }
            else if (key == ConsoleKey.D9 || key == ConsoleKey.NumPad9)
            {
                return "8";
            }
            else if (key == ConsoleKey.D0 || key == ConsoleKey.NumPad0)
            {
                return "9";
            }
            else if (key == ConsoleKey.V)
            {
                return "10";
            }
            else if (key == ConsoleKey.D)
            {
                return "11";
            }
            else if (key == ConsoleKey.R)
            {
                return "12";
            }
            else
            {
                return "1000";
            }
        }
    }
}
