using Spectre.Console;
namespace test_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool trouve = true;
            while (trouve)
            {
                if (i > 5) { trouve = false; }
                i = i * 3;
            }
            Console.WriteLine(i);
        }
    }
}
