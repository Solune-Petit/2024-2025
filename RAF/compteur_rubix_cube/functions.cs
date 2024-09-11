using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compteur_rubix_cube
{
    internal class functions
    {
        public void setup_cube(ref Lignes[] lignes, ref Colonnes[] colonnes, ref Rotations[] rotations)
        {

            //setup lignes

                //setup face 1
                for (int i = 0; i < 3; i++)
                {
                    lignes[i].L11 = "blanc";
                    lignes[i].L12 = "blanc";
                    lignes[i].L13 = "blanc";
                }

                //setup face 2
                for (int i = 0;i < 3;i++)
                {
                    lignes[i].L14 = "vert";
                    lignes[i].L15 = "vert";
                    lignes[i].L16 = "vert";
                }

                //setup face 3
                for (int i = 0; i < 3; i++)
                {
                    lignes[i].L17 = "jaune";
                    lignes[i].L18 = "jaune";
                    lignes[i].L19 = "jaune";
                }

                //setup face 4
                for (int i = 0; i < 3; i++)
                {
                    lignes[i].L14 = "bleu";
                    lignes[i].L15 = "bleu";
                    lignes[i].L16 = "bleu";
                }


            //setup colonnes
                //setup face 1
                for (int i = 0;i < 3; i++)
                {
                    colonnes[i].C11 = "blanc";
                    colonnes[i].C12 = "blanc";
                    colonnes[i].C13 = "blanc";
                }

                //setup face 2
                for (int i = 0; i < 3; i++)
                {
                    colonnes[i].C14 = "orange";
                    colonnes[i].C15 = "orange";
                    colonnes[i].C16 = "orange";
                }

                //setup face 3
                for (int i = 0; i < 3; i++)
                {
                    colonnes[i].C17 = "jaune";
                    colonnes[i].C18 = "jaune";
                    colonnes[i].C19 = "jaune";
                }

                //setup face 4
                for (int i = 0; i < 3; i++)
                {
                    colonnes[i].C110 = "rouge";
                    colonnes[i].C111 = "rouge";
                    colonnes[i].C112 = "rouge";
                }
        }
    }
}
