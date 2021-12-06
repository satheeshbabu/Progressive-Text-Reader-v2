using System;
using System.Threading.Tasks;

namespace Dottik.PTR2.Web 
{
    internal class SendRequest : WebObjects
    {
        /// <summary>
        /// Makes a request to a webpage, if the request is != than OK(200) this will fail... likely.
        /// </summary>
        public static async Task MakeRequest(string uri, WebObjects wObj)
        {
            wObj.httpResponseMessage = await wObj.httpClient.GetAsync(uri);
            try
            {
                wObj.httpResponseMessage.EnsureSuccessStatusCode();
                wObj.connectionFailed = false;
                wObj.connectionStablished = true;
            } catch (Exception ex)
            {
                Console.WriteLine("An error ocurred while making the web request to {0}\n\tError Message: {1}", uri, ex.Message);
                //Make the response null so we can avoid using it incorrectly
                wObj.connectionFailed = true;
                wObj.connectionStablished = false;
                wObj.httpResponseMessage = null;
            }
        }
    }
}
