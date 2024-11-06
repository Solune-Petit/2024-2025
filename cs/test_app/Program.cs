using Spectre.Console;
namespace test_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Foo");
            table.AddColumn(new TableColumn("Bar").Centered());

            // Add some rows
            table.AddRow("Baz", "[green]Qux[/]");
            table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

            // Render the table to the console
            AnsiConsole.Write(table);

            var choix = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("\n\n\n[yellow]veuillez choisir ce que vous voulez faire[/][grey] enter pour confirmer votre choix [/]")
                    .PageSize(13)
                    .AddChoices(new[] {
                        "view Byte", "redo", "bitSet","bitClear","bitChange","SetValBit","moveRight", "moveLeft", "bitRang", "quit"
                }));
            Console.Clear();
        }
    }
}
