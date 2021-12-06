﻿namespace Dottik.PTR2
{
    internal class ProgressiveReader : Program
    {
        public static async Task ReadLinesFromFile(string path, string fileName)
        {
            string finalPath = Path.Combine(path, fileName);
            string[] data = await File.ReadAllLinesAsync(finalPath);
            char[] chars;
            
            foreach (string a in data)
            {
                chars = a.ToCharArray();
                foreach (char b in chars)
                {
                    Write(b);
                    Thread.Sleep(int.Parse(dat.delayInMsec.ToString()));
                    dat.writtenChars++;
                }
                WriteLine();
            }
            EndRead();
        }
        public static void ReadLinesCustom(string? text)
        {
            if (text != null) 
            {
                char[] chars = text.ToCharArray();
                foreach (char b in chars)
                {
                    Write(b);
                    Thread.Sleep(int.Parse(dat.delayInMsec.ToString()));
                    dat.writtenChars++;
                } 
            }
            EndRead();
        }
        private static void EndRead()
        {
            WriteLine("\n Written {0} Characters!", dat.writtenChars);
            return;
        }
    }
}
