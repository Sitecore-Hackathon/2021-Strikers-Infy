using Newtonsoft.Json;
using StrikersInfy.Feature.Translator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StrikersInfy.Feature.Translator.Biz
{
    public class TranslateMgmt
    {
        private static readonly string subscriptionKey = "0fb9720191cc441f823051af5f89d525";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/";

        // Add your location, also known as region. The default is global.
        // This is required if using a Cognitive Services resource.
        private static readonly string location = "centralindia";

        public static async Task<string> TranslateContent(ContentProps data)
        {
            // Input and output languages are defined as parameters.
            string route = "/translate?api-version=3.0&from=en&to=" + data.LangCode;
            string textToTranslate = data.ContentText;
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    List<TranslationRes> transList = JsonConvert.DeserializeObject<List<TranslationRes>>(result);
                    if (transList != null && transList.Count > 0)
                    {
                        Translation[] firstRes = transList.Select(r => r.translations).FirstOrDefault();
                        if (firstRes != null && firstRes.Length > 0)
                        {
                            string res = firstRes.Select(r => r.text).FirstOrDefault();
                            if (!string.IsNullOrWhiteSpace(res))
                            {
                                return res;
                            }
                        }
                    }
                }
                return null;
            }
        }
    }
}