using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace GarzaTech.Core.System
{
    public class WebQueryBase<TResponse>
        where TResponse: new()
    {
        private string _api;

        public WebQueryBase(string api)
        {
            _api = api;
        }

        public async Task<TResponse> Call(string query)
        {
            try
            {
                var response = string.Empty;
                var webRequest = (HttpWebRequest)WebRequest.Create(_api + query);
                webRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                webRequest.Headers.Add(HttpRequestHeader.Accept, "application/vnd.github.v3+json");
                webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (var webResponse = await webRequest.GetResponseAsync())
                using (var sr = new StreamReader(webResponse.GetResponseStream()))
                {
                    response = sr.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<TResponse>(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}
