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

            string customText;
            foreach (var argument in args)
            {
                if (argument.Contains("--latency="))
                {
                    string[] msec = argument.Split('=');
                    if (!int.TryParse(msec[1], out dat.delayInMsec))
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        Write("Invalid Latency value! Try again.");
                        ForegroundColor = ConsoleColor.Gray;
                        Environment.Exit(69); /*😳*/
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
                    case "--create-text-file":
                        WriteLine("Creating text file...");
                        File.Create(dat.textFile);
                        WriteLine("Done!");
                        Environment.Exit(0);
                        break;
                }
            }
            switch (dat.programMode)
            {
                case "help":
                    Help.PrintHelp();
                    break;

                default:
                    WriteLine("There was no argument charged. Is this a test? Ok, Loading Help Statement...");
                    Help.PrintHelp();
                    ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
