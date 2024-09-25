using _5T24_PetitSolune_enigma;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace _5TTI_PetitSolune_doubleursExercices5678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorChanger couleur = new ColorChanger();
            fonctions mesOutils = new fonctions();



            couleur.blue();
            Console.WriteLine("Bienvenue dans mon projet !!!");
            couleur.green();
            Console.WriteLine("que voulez-vous faire ?");
            couleur.red();
            Console.WriteLine(  "1 : savoir si un entier naturel que vous proposez est cubique ou non" +
                                "\n2 : déterminer tous les chiffres qui divisent un nombre (valeur max : 10000)\n" +
                                "3 : trouver un nombre naturel entre de valeurs\n" +
                                "4 : générer les premiers nombres premiers");
        }
    }
}
