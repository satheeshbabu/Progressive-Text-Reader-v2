using System;
using System.Net.Http;

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
        public string programMode = "test";
        public readonly string author = "Dottik";
        public readonly string textFile = "read-this.txt";
        public int delayInMsec = 50;
    }
    public class JSONHandling
    {
        protected string? Version { get; set; }
    }
}
