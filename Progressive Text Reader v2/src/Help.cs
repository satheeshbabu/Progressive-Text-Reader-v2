namespace Dottik.PTR2
{
    internal class Help : Program
    {
        public static void PrintHelp()
        {
            MarkupLine("[cyan]###########################################[/]");
            MarkupLine("[cyan]#[green1]------[/] [orange1]Progressive Text Reader[/] [white]2.0[/] [green1]------[/]#[/]");
            MarkupLine("[cyan]#[green1]------[/]         By [underline red]Dottik[/]           [green1]------[/]#[/]");
            MarkupLine("[cyan]###########################################[/]");
            MarkupLine("[cyan]###########################################[/]");

            MarkupLine("[cyan]###########################################[/]");

            MarkupLine("[cyan]#####[/][green]\t--help                       [red]||[/] Prints this message[/]");
            MarkupLine("[cyan]#####[/]");
            MarkupLine("[cyan]#####[/][green]\t--custom                     [red]||[/] Type text in console and then it get's printed, no file needed[/]");
            MarkupLine("[cyan]#####[/]");
            MarkupLine("[cyan]#####[/][green]\t--create-text                [red]||[/] Creates the text file that the program reads to print[/]");
            MarkupLine("[cyan]#####[/]");
            MarkupLine("[cyan]#####[/][green]\t--latency=[blue]<Miliseconds>[/]      [red]||[/] Add a custom latency![/]");
            MarkupLine("[cyan]#####[/]");
            MarkupLine("[cyan]#####[/][green]\t--read-file                  [red]||[/] Read the text file created by the program![/]");
            MarkupLine("[cyan]###########################################[/]");
        }
    }
}
