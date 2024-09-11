namespace compteur_rubix_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {

            functions toolBox = new functions();

            Lignes[] lignes = new Lignes[3];
            Colonnes[] colonnes = new Colonnes[3];
            Rotations[] rotations = new Rotations[3];

            Console.WriteLine("\r\n██████╗░██╗░░░██╗██████╗░██╗██╗░░██╗  ░█████╗░██╗░░░██╗██████╗░███████╗\r\n██╔══██╗██║░░░██║██╔══██╗██║╚██╗██╔╝  ██╔══██╗██║░░░██║██╔══██╗██╔════╝\r\n██████╔╝██║░░░██║██████╦╝██║░╚███╔╝░  ██║░░╚═╝██║░░░██║██████╦╝█████╗░░\r\n██╔══██╗██║░░░██║██╔══██╗██║░██╔██╗░  ██║░░██╗██║░░░██║██╔══██╗██╔══╝░░\r\n██║░░██║╚██████╔╝██████╦╝██║██╔╝╚██╗  ╚█████╔╝╚██████╔╝██████╦╝███████╗\r\n╚═╝░░╚═╝░╚═════╝░╚═════╝░╚═╝╚═╝░░╚═╝  ░╚════╝░░╚═════╝░╚═════╝░╚══════╝\n\n\n\n\n\n");

            Console.ReadKey();

            toolBox.setup_cube(ref lignes, ref colonnes, ref rotations);
        }
    }
}
