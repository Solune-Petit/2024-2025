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
    }
}
