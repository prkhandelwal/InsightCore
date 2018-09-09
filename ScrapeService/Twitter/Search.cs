using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace ScrapeService.Twitter
{
    public class Search
    {
        public static IEnumerable<Tweetinvi.Models.ITweet> Tweets;

        public async static Task<List<MultiLanguageInput>> GetTweets(string query)
        {
            List<MultiLanguageInput> TweetInput = new List<MultiLanguageInput>();
            Auth.SetUserCredentials(creds.ConsumerKey, creds.ConsumerSecret, creds.AccessToken, creds.AccessSecret);
            //var tweets = await SearchAsync.SearchTweets(query);
            Tweets = await SearchAsync.SearchTweets(query);
            List<Tweetinvi.Models.ITweet> tweetList = Tweets.ToList();
            int i = 0;
            foreach (Tweetinvi.Models.ITweet item in tweetList)
            {
                var k = new MultiLanguageInput("en", i.ToString(), item.FullText);
                TweetInput.Add(k);
                i++;
            }
            return TweetInput;
        }
    }
}
