namespace Dottik.PTR2.IO
{
    internal class ReadFile
    {
        public static async Task<string[]> ReadFileAsync(string path, string fileName)
        {
            string[] aSt = fileName.Split('.'), errMsg = {"This type of file (non .txt) files aren't ment to be read with this function!"};
            int a = aSt.Length;
            if (aSt[a] == ".txt")
            { 
                string finalPath = Path.Combine(path, fileName);
                string[] fileContent;
                try
                {
                    fileContent = await File.ReadAllLinesAsync(finalPath);
                    return fileContent;
                } catch (Exception ex)
                {
                    MarkupLine("There is [bold red]no[/] file in path {0} with the name {1}\n[underline bold red]Error Message: {2}[/]", path, fileName, ex.Message);
                    throw;
                }
                
            }
            return errMsg;
        }   
    }
}
