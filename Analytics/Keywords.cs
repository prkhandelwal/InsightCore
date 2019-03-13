using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using Microsoft.Rest;

namespace Analytics
{

    public class Keywords
    {
        class ApiKeyServiceClientCredentials : ServiceClientCredentials
        {
            public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                request.Headers.Add("Ocp-Apim-Subscription-Key", AppSecrets.CognitiveApiKeys);
                var k = base.ProcessHttpRequestAsync(request, cancellationToken);
                return k;
            }
        }

        public static List<string> GetKeyWords(string query)
        {
            // Create a client.
            ITextAnalyticsClient client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials())
            {
                Endpoint = "https://southeastasia.api.cognitive.microsoft.com"
            };

            KeyPhraseBatchResult Result = client.KeyPhrasesAsync(new MultiLanguageBatchInput(
                        new List<MultiLanguageInput>()
                        {
                            new MultiLanguageInput("en","1",query)
                        })).Result;

            List<string> keyPhrases = Result.Documents[0].KeyPhrases as List<string>;

            return keyPhrases;
        }
    }
}
