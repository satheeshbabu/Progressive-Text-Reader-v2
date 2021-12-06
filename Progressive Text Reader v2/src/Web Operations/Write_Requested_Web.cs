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
                WriteLine("There was not a stablished connection, downloading a file is just impossible!");
            } else {

                //State our Final Path
                string finalPath = Path.Combine(pathToSave, fileName);

                //Create a memory stream that is equal to the content of our previous request, then
                //Create a file and write our memoryStream to it
                WriteLine("Debug - Readoing Memory Stream...");
                Stream memoryStream = await wObj.httpResponseMessage.Content.ReadAsStreamAsync();
                WriteLine("Debug - Creating File...");
                FileStream file = File.Create(finalPath);
                WriteLine("Debug - Writing Memory Stream to File...");
                await memoryStream.CopyToAsync(file);
                WriteLine("Debug - Done!");

                WriteLine("Debug - Flushing & Closing Memory and File stream...");
                //When done we flush and close the streams to cheap out on resources
                await file.FlushAsync();
                await memoryStream.FlushAsync();
                file.Close();
                memoryStream.Close();
                WriteLine("Debug - Done!");
            }
        }
    }
}
