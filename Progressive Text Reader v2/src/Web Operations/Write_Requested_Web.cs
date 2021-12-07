namespace Dottik.PTR2.Web
{
    internal class Write : WebObjects
    {
        /// <summary> 
        /// Take our previous data downloaded from the Web with the SendRequest class and the MakeRequest method
        /// and make it into a file of our choice
        /// </summary>
        public static async Task WriteFile(string pathToSave, string fileName, WebObjects wObj)
        {
            if (wObj.connectionFailed || !wObj.connectionStablished && wObj.httpResponseMessage != null) {
                MarkupLine("[underline bold red]There was not a stablished connection, downloading a file is just impossible![/]");
            } else {

                //State our Final Path
                string finalPath = Path.Combine(pathToSave, fileName);

                //Create a memory stream that is equal to the content of our previous request, then
                //Create a file and write our memoryStream to it
                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [orange1]Reading Memory Stream...[/]");
                Stream memoryStream = await wObj.httpResponseMessage.Content.ReadAsStreamAsync();
                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [orange1]Creating File...[/]");
                FileStream file = File.Create(finalPath);
                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [orange1]Writing Memory Stream to File...[/]");
                await memoryStream.CopyToAsync(file);
                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [green1]Done![/]");

                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [orange1]Flushing & Closing Memory and File stream...[/]");
                //When done we flush and close the streams to cheap out on resources
                await file.FlushAsync();
                await memoryStream.FlushAsync();
                file.Close();
                memoryStream.Close();
                MarkupLine("[underline bold red]Debug[/] [green2]-[/] [green1]Done![/]");
            }
        }
    }
}
