using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_PetitSolune_doubleursExercice9
{
    internal class fonctions
    {

        public void setBit(ref int[] bit)
        {
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i] = 0;
            }
        }

        public void bitSet(int nombre, ref int[] bit)
        {
            bit[nombre] = 1;
        }

        public void bitClear(int nombre, ref int[] bit)
        {
            bit[nombre] = 0;
        }

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
        public void setValBit(int place, int valeur, ref int[] bit)
        {
            bit[place] = valeur;
        }
    }
}
