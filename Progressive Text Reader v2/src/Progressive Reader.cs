namespace Dottik.PTR2
{
    internal class ProgressiveReader : Program
    {
        public static async Task ReadLines(string path, string fileName)
        {
            string finalPath = Path.Combine(path, fileName);
            string[] data = await File.ReadAllLinesAsync(finalPath);
            char[] chars;
            
            foreach (string a in data)
            {
                chars = a.ToCharArray();
                foreach (char b in chars)
                {
                    WriteLine(b);
                    Thread.Sleep(dat.delayInMsec);
                }
            }
        }
    }
}
