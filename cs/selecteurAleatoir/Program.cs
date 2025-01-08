using Spectre.Console;

namespace selecteurAleatoir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fonctions fonctions = new Fonctions();
            int nbrAbsents = 0;
            fonctions.CreateList(out string[] listeEleves);

            var choix = AnsiConsole.Prompt
            (
                new MultiSelectionPrompt<string>()
                .Title("Sélecteur d'élèves aléatoire\n\n\nVeuillez sélectionner les absents :")
                .NotRequired()
                .InstructionsText("Appuyez sur la touche 'espace' pour sélectionner un absent. Si vous voulez faire en sortes que l'élève sélectionné ne puisses plus être ne pas sélectionné," +
                " cochez la case 'ne pas sélectionner'. Pour confirmer, appuyez sur la touche 'enter'")
                .PageSize(6)
                .AddChoices
                (new[]
                    {
                        "Farhan Abuzour","Amaury Aibach","Manu Braibant","Augustin Collin","Arnaud Crevecoeur","Alex Debienne","Mathéis Dethier","Blaze Girboux","Alexandre Kokelberg",
                        "Maxence Limet","Nathan Marcq","Aimeric Mathieu","Solune Petit","Marcel Tasnier","ne pas sélectionner"
                    }
                )
            );

            List<string> absents = choix.Where(x => !listeEleves.Contains(x)).ToList();

            // Afficher le résultat
            Console.WriteLine("Les élèves absents sont:");
            foreach (string absent in absents)
            {
                Console.WriteLine(absent);
            }

            while (true)
            {
                Random rnd = new Random();
                bool absChoisis = false;

                int choisis = rnd.Next( listeEleves.Length );

                //for(int i = 0; i < absents.Length; i++)
                //{
                //    if (choisis == i)
                //    {
                //        absChoisis = true;
                //    }
                //}

                //if (!absChoisis)
                //{
                //    if (choix[choix.Count() - 1] == "ne pas sélectionner")
                //    {
                //        absents[nbrAbsents] = choisis;
                //    }


                //    AnsiConsole.Write(new Markup("La victime choisie est :[bold red underline]" + listeEleves[choisis]+ "[/][grey]\n\nAppuyez sur n'importe quelle touche pour choisir une autre" +
                //        " victime"));
                //    Console.ReadKey();
                //}
            }
        }
    }
}
