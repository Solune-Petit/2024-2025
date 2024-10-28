using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_PetitSolune_doubleursExercice9
{
    internal class fonctions
    {

        //mettre à 0 le byte
        public void setBit(ref int[] bit)
        {
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i] = 0;
            }
        }

        public void renderBit(int[] Bite, ref Spectre.Console.Table table)
        {
            table = new Table();

            // Add some columns
            table.AddColumn("place numéro");
            table.AddColumn(new TableColumn("1").Centered());
            table.AddColumn(new TableColumn("2").Centered());
            table.AddColumn(new TableColumn("3").Centered());
            table.AddColumn(new TableColumn("4").Centered());
            table.AddColumn(new TableColumn("5").Centered());
            table.AddColumn(new TableColumn("6").Centered());
            table.AddColumn(new TableColumn("7").Centered());
            table.AddColumn(new TableColumn("8").Centered());

            // Add some rows
            table.AddRow("valeur bit", Bite[0].ToString(), Bite[1].ToString(), Bite[2].ToString(), Bite[3].ToString(), Bite[4].ToString(), Bite[5].ToString(), Bite[6].ToString(), Bite[7].ToString());

            table.Border(TableBorder.Rounded);
            table.Expand();
        }

        //changer un bit en 1 dans le byte
        public void bitSet(int nombre, ref int[] bit)
        {
            bit[nombre] = 1;
        }

        //changer un bit en 0 dans le byte
        public void bitClear(int nombre, ref int[] bit)
        {
            bit[nombre] = 0;
        }

        //flip la valeur d'un bit dans le byte
        public void bitChange(int nombre, ref int[] bit)
        {
            if (bit[nombre] == 0)
            {
                bit[nombre] = 1;
            }
            else
            {
                bit[nombre] = 0;
            }
        }
        //changer un bit en 1 ou 0 en fonction de l'utilisateur dans le byte
        public void setValBit(int place, int valeur, ref int[] bit)
        {
            bit[place] = valeur;
        }

        //décaler de x places vers la droite les bits du byte
        public void moveRight(int nombre, ref int[] bit)
        {
            for (int i = 0; i < nombre; i++)
            {
                for(int j = 7; j >0; j--)
                {
                    bit[j] = bit[j - 1];
                }
                bit[0] = 0;
            }
        }
    }
}
