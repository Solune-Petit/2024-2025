using _5T24_PetitSolune_enigma;
using System;
using System.Security.Cryptography.X509Certificates;

public class fonctions
{

    ColorChanger couleur = new ColorChanger();

    public void trouveSiCubique(string nombre, out string message)
    {
        int addition = 0;
        message = "";

        for (int i = 0; i < nombre.Length; i++)
        {
            // Convertir le caractère en entier avant de calculer le cube
            int chiffre = int.Parse(nombre[i].ToString());
            addition += (int)Math.Pow(chiffre, 3);
        }

        if (addition == int.Parse(nombre))
        {
            couleur.green();
            message = "le nombre est cubique";
        }
        else
        {
            couleur.red();
            message = "le nombre n'est pas cubique";
        }
    }

    public void chiffresDiviseurs(int nombre, out string nombresPossible)
    {
        nombresPossible = "les diviseurs possibles de ce nombre sont : ";

        for (int i = 1; i < 10; i++)
        {
            if ((nombre % i) == 0)
            {
                nombresPossible += "[" + i + "]";
            }
        }
    }

    public void nombresPremiers(int nbrNombresPremiersDemande, out int[] premiers)
    {
        premiers = new int[nbrNombresPremiersDemande];
        int count = 0;
        int nombre = 2;

        while (count != nbrNombresPremiersDemande)
        {
            bool estPremier = true;

            if (nombre <= 1)
            {
                estPremier = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(nombre); i++)
                {
                    if (nombre % i == 0)
                    {
                        estPremier = false;
                        i = (int)Math.Sqrt(nombre) + 1;
                    }
                }
            }

            if (estPremier)
            {
                premiers[count] = nombre;
                count++;
            }
            nombre++;
        }
    }

    public void nombresParfait(int start, int end, out string message)
    {
        message = "les nombres parfaits entre " + start + " et " + end + " sont : ";
        for (int i = start; i <= end; i++)
        {
            int testAdd = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0 && i != j)
                {
                    testAdd += j;
                }
            }
            if (testAdd == i)
            {
                message += "[" + i.ToString() + "]";
            }
        }
    }
}
