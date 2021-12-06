namespace Dottik.PTR2.IO
{
    internal class Decompress
    {
        protected static void DecompressZip(string pathToFile, string unZipLocation)
        {
            ZipFile.ExtractToDirectory(pathToFile, unZipLocation);
        }
    }
}
