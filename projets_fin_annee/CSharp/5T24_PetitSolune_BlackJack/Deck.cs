using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_PetitSolune_BlackJack
{
    namespace Deck
    {
        struct Card
        {
            // Couleur de la carte (par exemple, "♦", "♠", "♣", "♥")
            public string Suit { get; set; }

            // Rang de la carte (par exemple, "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valet", "Dame", "Roi")
            public string Rank { get; set; }

            // Représentation textuelle de la carte
            public string Image { get; set; }

            // Valeur de la carte en points
            public string Points { get; set; }

            // Constructeur de la structure Card
            public Card(string suit, string rank, string image, string points)
            {
                // Initialisation des attributs de la carte
                Suit = suit;
                Rank = rank;
                Image = image;
                Points = points;
            }
        }

        // Structure pour représenter un jeu de cartes
        struct deck
        {
            // Liste des cartes dans le jeu
            public List<Card> Cards { get; set; }

            // Constructeur de la structure Deck
            public deck()
            {
                // Initialisation de la liste de cartes
                Cards = new List<Card>();

                // Tableau des couleurs de cartes
                string[] suits = { "♦", "♠", "♣", "♥" };

                // Tableau des rangs de cartes
                string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "V", "D", "R" };


                // Boucle pour créer toutes les cartes du jeu
                foreach (string suit in suits)
                {
                    // Compteur pour les points des cartes
                    int i = 1;
                    string temp;
                    foreach (string rank in ranks)
                    {
                        if (rank == "A")
                        {
                            temp = "1";
                        }
                        else if (rank == "V" || rank == "D" || rank == "R")
                        {
                            temp = "10";
                        }
                        else
                        {
                            i++;
                            temp = i.ToString();
                        }

                        // Création de l'image de la carte
                        string image = $" ------- \r\n|{suit}     {suit}|\r\n|       |\r\n|   {rank}   |\r\n|       |\r\n|{suit}     {suit}|\r\n ------- ";

                        // Ajout de la carte au jeu
                        Cards.Add(new Card(suit, rank, image, temp));
                    }
                }
            }
        }
    }
}
