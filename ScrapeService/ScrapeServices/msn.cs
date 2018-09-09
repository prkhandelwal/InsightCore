using HtmlAgilityPack;
using Newtonsoft.Json;
using ScrapeService.Models;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeService.ScrapeServices
{
    public class msn
    {
        private static ScrapingBrowser Browser = new ScrapingBrowser();
        //public List<msnData> HeadLines = new List<msnData>();


        //Get Sports
        public async static Task<string> GetSports()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36 Edge/15.15063");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/sports/"));
            //HtmlNode Title = MainPage.Html.CssSelect(".navbar-brand").First();
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".hl1u1").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            for (int i = 0; i < subHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            string SerializedData = JsonConvert.SerializeObject(HeadLines);

            return SerializedData;
        }

        //Get Money
        public async static Task<string> GetMoney()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36 Edge/15.15063");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/money/"));
            //HtmlNode Title = MainPage.Html.CssSelect(".navbar-brand").First();
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".hl1u1").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            for (int i = 0; i < subHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            string SerializedData = JsonConvert.SerializeObject(HeadLines);

            return SerializedData;
        }

        //Get Entertainment
        public async static Task<string> GetEntertainment()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36 Edge/15.15063");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/entertainment/"));
            //HtmlNode Title = MainPage.Html.CssSelect(".navbar-brand").First();
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".hl1u1").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            for (int i = 0; i < subHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            string SerializedData = JsonConvert.SerializeObject(HeadLines);

            return SerializedData;
        }

        //Get News
        public async static Task<string> GetNews()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36 Edge/15.15063");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/news/"));
            //HtmlNode Title = MainPage.Html.CssSelect(".navbar-brand").First();
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".hl1u1").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            for (int i = 0; i < subHeadLines.Count(); i++)
            {
                msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
                HeadLines.Add(data);
            }

            string SerializedData = JsonConvert.SerializeObject(HeadLines);

            return SerializedData;
        }
    }
}
