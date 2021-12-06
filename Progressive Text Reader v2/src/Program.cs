namespace Dottik.PTR2
{
    internal class Program : WebObjects
    {
        protected static Data dat = new();
        /// <summary>
        /// The program's entry point, here is where the fun begins!
        /// </summary>
        static async Task Main(string[] args)
        {
            ///     |----------------------------------------------------------------------------------------------------------------|
            ///     |  Generate new instance of data and WebObjects, avoids deadlocks in certain circumstances, see                  |
            ///     |  https://docs.microsoft.com/en-gb/dotnet/fundamentals/code-analysis/quality-rules/ca2211 for more information  |
            ///     |----------------------------------------------------------------------------------------------------------------|
            foreach (var argument in args)
            {
                if (argument.Contains("--latency="))
                {
                    string[] msec = argument.Split('=');
                    if (!long.TryParse(msec[1], out dat.delayInMsec))
                    {
                        Clear();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Markup("[red]Invalid [underline]Latency[/] value! Try again.[/]");
                        System.Console.ForegroundColor = ConsoleColor.Gray;
                        Environment.Exit(69); /*:flushed:*/
                    }
                }
                switch (argument)
                {
                    case "--help":
                        dat.programMode = "help";
                        break;
                    case "--custom":
                        dat.programMode = "customText";
                        break;
                    case "--create-text":
                        MarkupLine("[orange1]Creating text file...[/]");
                        File.CreateText(dat.textFile);
                        MarkupLine("[green1]Done![/]");
                        Environment.Exit(0);
                        break;
                    case "--read-file":
                        dat.programMode = "readFile";
                        break;
                }
            }

            switch (dat.programMode)
            {
                case "readFile":
                    await ProgressiveReader.ReadLinesFromFile(path: Environment.CurrentDirectory, fileName: dat.textFile);
                    break;
                case "customText":
                    ProgressiveReader.ReadLinesCustom(text: AnsiConsole.Ask<string>("Write [underline red]your[/] custom text here: "));
                    break;
                case "help":
                    Help.PrintHelp();
                    break;
                default:
                    Help.PrintHelp();
                    Environment.Exit(0);
                    break;
            } 
        }
    }
}
