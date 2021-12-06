namespace Dottik.PTR2
{
    internal class WebObjects
    {
        internal HttpClient httpClient = new();
        internal HttpResponseMessage? httpResponseMessage = new();
        internal bool connectionFailed = true;
        internal bool connectionStablished = false;
    }
    public class Data
    {
        //RW Strings
        public string programMode = "test";
        
        //RO Strings
        public readonly string author = "Dottik";
        public readonly string textFile = "read-this.txt";
        
        //RW Signed Integers
        public int delayInMsec = 50;
        
    }
    public class JSONHandling
    {
        protected string? Version { get; set; }
    }
}
