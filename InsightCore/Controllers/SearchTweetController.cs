using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Analytics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsightCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchTweetController : ControllerBase
    {
        public async Task<IActionResult> SearchTweet(string query)
        {
            string myQuery = "";
            List<string> keyPhraseData = Keywords.GetKeyWords(query);

            foreach (string item in keyPhraseData)
            {
                myQuery += item + " ";
            }

            double? Score = await Sentiment.GetSentiment(myQuery);

            //var response = this.Request.CreateResponse(HttpStatusCode.OK);

            //response.Content = new StringContent(Score.ToString(), Encoding.UTF8, "application/json");

            //return response;

            return new ObjectResult(Score);
        }
    }
}