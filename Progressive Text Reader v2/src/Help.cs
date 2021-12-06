namespace Dottik.PTR2
{
    internal class Help : Program
    {
        public static void PrintHelp()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("###########################################");
            WriteLine("#------ Progressive Text Reader 2.0 ------#");
            WriteLine("#------         By Dottik           ------#");
            WriteLine("###########################################");
            WriteLine("###########################################");

            WriteLine("###########################################");

            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("    --help                    || Prints this message");
            Write("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("    --custom                  || Type text in console and then it get's printed, no file needed");
            Write("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("    --create-text             || Creates the text file that the program reads to print");
            Write("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("    --latency=<Miliseconds>   || Add a custom latency!");

        }
    }
}
