using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using Microsoft.Rest;
using ScrapeService.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Analytics
{
    public class Sentiment
    {

        static string subscriptionKey = "147dbdfd7dc948c7af909d154166ac32";

        class ApiKeyServiceClientCredentials : ServiceClientCredentials
        {
            public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                request.Headers.Add("Ocp-Apim-Subscription-Key", "147dbdfd7dc948c7af909d154166ac32");
                return base.ProcessHttpRequestAsync(request, cancellationToken);
            }
        }

        public async static Task<double?> GetSentiment(string query)
        {
            // Create a client.
            ITextAnalyticsClient client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials())
            {
                Endpoint = "https://southeastasia.api.cognitive.microsoft.com"
            };
            

            List<MultiLanguageInput> Tweets = await Search.GetTweets(query);

            SentimentBatchResult resultSentiment = await client.SentimentAsync(new MultiLanguageBatchInput(Tweets));

            double? sumScore = 0;

            foreach (SentimentBatchResultItem item in resultSentiment.Documents)
            {
                sumScore += item.Score;
            }

            double? avgScore = sumScore / resultSentiment.Documents.Count();

            return avgScore;

        }
    }
}
