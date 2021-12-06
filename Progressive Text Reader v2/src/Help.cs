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

            ForegroundColor = ConsoleColor.Cyan;
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("\t--help                       || Prints this message"); ForegroundColor = ConsoleColor.Cyan; 
            WriteLine("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("\t--custom                     || Type text in console and then it get's printed, no file needed"); ForegroundColor = ConsoleColor.Cyan;
            WriteLine("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("\t--create-text                || Creates the text file that the program reads to print"); ForegroundColor = ConsoleColor.Cyan;
            WriteLine("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("\t--latency=<Miliseconds>      || Add a custom latency!"); ForegroundColor = ConsoleColor.Cyan;
            WriteLine("#####");
            Write("#####"); ForegroundColor = ConsoleColor.Green; WriteLine("\t--read-file                  || Read file created by the program!"); ForegroundColor = ConsoleColor.Cyan;
            WriteLine("###########################################");
            ForegroundColor = ConsoleColor.Gray;
        }
    }
}
