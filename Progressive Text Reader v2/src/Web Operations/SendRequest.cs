namespace Dottik.PTR2.Web 
{
    internal class SendRequest : WebObjects
    {
        /// <summary>
        /// Makes a request to a webpage, if the request is != than OK(200) this will fail... likely.
        /// </summary>
        public static async Task<WebObjects?> MakeRequest(string uri, WebObjects wObj)
        {
            wObj.httpResponseMessage = await wObj.httpClient.GetAsync(uri);
            try
            {
                wObj.httpResponseMessage.EnsureSuccessStatusCode();
                wObj.connectionFailed = false;
                wObj.connectionStablished = true;
                return wObj;
            } catch (Exception ex)
            {
                MarkupLine("An [red underline bold]error[/] ocurred while making the web request to [underline bold cyan]{0}[/]\n\tError Message: [underline bold red]{1}[/]", uri, ex.Message);
                //Make the response null so we can avoid using it incorrectly
                wObj.connectionFailed = true;
                wObj.connectionStablished = false;
                wObj.httpResponseMessage = null;
            }
            return null;
        }
    }
}
