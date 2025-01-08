namespace createur_De_Lignes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int cases = 0; cases < 17; cases++)
            {
                Console.WriteLine("     case '" + cases + "':");
                        Console.WriteLine("" +
                        "digitalWrite(LED01, HIGH);" +
                        "digitalWrite(LED10, HIGH);" +
                        "delay(1000);              " +
                        "digitalWrite(LED01, LOW); " +
                        "digitalWrite(LED10, LOW); " +
                        "break");

            }
        }
    }
}
