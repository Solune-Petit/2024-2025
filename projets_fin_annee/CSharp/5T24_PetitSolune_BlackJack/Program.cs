namespace _5T24_PetitSolune_BlackJack
{
    using Function; // Utilise le namespace Function

    namespace _5T24_PetitSolune_BlackJack
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Créer un nouveau jeu de cartes
                Deck deck = new Deck();

                // Afficher chaque carte du jeu
                foreach (Card card in deck.Cards)
                {
                    Console.WriteLine(card.Image);
                    Console.WriteLine(); // Ajouter une ligne vide entre chaque carte
                }

                Console.ReadKey(); // Attendre une touche pour terminer le programme
            }
        }
    }
}