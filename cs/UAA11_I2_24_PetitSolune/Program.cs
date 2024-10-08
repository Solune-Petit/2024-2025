using static System.Net.Mime.MediaTypeNames;

namespace UAA11_I2_24_PetitSolune
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //création des variables
            int longueur;
            int largeur;
            int hauteur;
            int poids;
            string Uinput;
            bool restart = true;

            while (restart)
            {

                Console.WriteLine("programme de la poste\n\n" +
                    "veuillez entrer la largeur de votre colis");
                largeur = int.Parse(Console.ReadLine()); //assignation de la variable largeur
                Console.WriteLine("veuillez entrer la longueur de votre colis");
                longueur = int.Parse(Console.ReadLine()); //assignation de la variable longueur
                Console.WriteLine("veuillez entrer la hauteur de votre colis");
                hauteur = int.Parse(Console.ReadLine()); //assignation de la variable hauteur
                Console.WriteLine("veuillez entrer le poids de votre colis");
                poids = int.Parse(Console.ReadLine()); //assignation de la variable poids

                calculTaxe(longueur, largeur, hauteur, poids, out string message); //appel de la fonction calculTaxe

                Console.WriteLine(message);//écriture de message




                //demande si il faut recommencer
                do
                {
                    Console.WriteLine("voulez-vous recommencer (Y/N)");
                    Uinput = Console.ReadLine().ToUpper();
                } while (Uinput != "Y" || Uinput != "N");
            }
        }

        public static void calculTaxe(int longueur, int largeur, int hauteur, int poids, out string message)
        {
            message = "";
            int prixTaxe = 0;
            int volume = largeur * longueur * hauteur / 1000; // calcul du volume du colis
            
            if (poids > 10) // test pour savoir si le colis est trop lourd
            {
                message = "colis hors normes";
            }
            else
            {
                if (largeur > 50 || longueur > 50 || hauteur > 50) // test pour savoir si les dimensions sont hors normes
                {
                    message = "colis hors normes";
                }
                else
                {
                    prixTaxe = 12;
                    if (poids >= 5 && poids <= 10) // test pour savoir si le colis doit subir une taxe de 5€ pour le poids
                    {
                        prixTaxe += 5;
                    }

                    if (volume >= 27) // test pour savoir si le colis doit subir une taxe de 8€ si le volume est plus grand que 27cm³
                    {
                        prixTaxe += 8;
                    }

                    message = "vous allez devoir payer " + prixTaxe + "€ de taxe"; // assignation de la variable message
                }
            }
        }
    }
}
