﻿using HtmlAgilityPack;
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
        public async static Task<List<msnData>> GetSports()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/sports/"));
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            //List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".rc-item-js rc-item show").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                //msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["div"].ChildNodes["div"].ChildNodes["ul"].ChildNodes["li"].ChildNodes["a"].Attributes["href"].Value };
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value, ImgUri = mainHeadLines[i].ChildNodes["a"].ChildNodes["img"].Attributes["src"].Value };
                HeadLines.Add(data);
            }

            //for (int i = 0; i < subHeadLines.Count(); i++)
            //{
            //    msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
            //    HeadLines.Add(data);
            //}

            //string SerializedData = JsonConvert.SerializeObject(HeadLines);
            //return SerializedData;

            return HeadLines;
        }

        //Get Money
        public async static Task<List<msnData>> GetMoney()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/money/"));
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            //List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".rc-item-js rc-item show").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                //msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["div"].ChildNodes["div"].ChildNodes["ul"].ChildNodes["li"].ChildNodes["a"].Attributes["href"].Value };
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value, ImgUri = mainHeadLines[i].ChildNodes["a"].ChildNodes["img"].Attributes["src"].Value };
                HeadLines.Add(data);
            }

            //for (int i = 0; i < subHeadLines.Count(); i++)
            //{
            //    msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
            //    HeadLines.Add(data);
            //}

            //string SerializedData = JsonConvert.SerializeObject(HeadLines);
            //return SerializedData;

            return HeadLines;
        }

        //Get Entertainment
        public async static Task<List<msnData>> GetEntertainment()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("http://www.msn.com/en-in/entertainment/"));
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".skylinehl1u1").ToList();
            //List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".rc-item-js rc-item show").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                //msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["div"].ChildNodes["div"].ChildNodes["ul"].ChildNodes["li"].ChildNodes["a"].Attributes["href"].Value };
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value, ImgUri = mainHeadLines[i].ChildNodes["a"].ChildNodes["img"].Attributes["src"].Value };
                HeadLines.Add(data);
            }

            //for (int i = 0; i < subHeadLines.Count(); i++)
            //{
            //    msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
            //    HeadLines.Add(data);
            //}

            //string SerializedData = JsonConvert.SerializeObject(HeadLines);
            //return SerializedData;

            return HeadLines;
        }

        //Get News
        public async static Task<List<msnData>> GetNews()
        {
            List<msnData> HeadLines = new List<msnData>();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = false;
            Browser.UserAgent = new FakeUserAgent("EdgeAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            WebPage MainPage = await Browser.NavigateToPageAsync(new Uri("https://www.msn.com/en-in/news/"));
            //HtmlNode Title = MainPage.Html.CssSelect(".navbar-brand").First();
            HtmlNode Title = MainPage.Html.CssSelect("title").FirstOrDefault();
            string titleName = Title.InnerText;
            List<HtmlNode> mainHeadLines = MainPage.Html.CssSelect(".smalla").ToList();
            //List<HtmlNode> subHeadLines = MainPage.Html.CssSelect(".rc-item-js rc-item show").ToList();
            for (int i = 0; i < mainHeadLines.Count(); i++)
            {
                //msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["div"].ChildNodes["div"].ChildNodes["ul"].ChildNodes["li"].ChildNodes["a"].Attributes["href"].Value };
                msnData data = new msnData() { Category = "Main", InnerText = mainHeadLines[i].InnerText.CleanInnerText(), href = mainHeadLines[i].ChildNodes["a"].Attributes["href"].Value, ImgUri = mainHeadLines[i].ChildNodes["a"].ChildNodes["img"].Attributes["src"].Value };
                HeadLines.Add(data);
            }

            //for (int i = 0; i < subHeadLines.Count(); i++)
            //{
            //    msnData data = new msnData() { Category = "Sub", InnerText = subHeadLines[i].InnerText.CleanInnerText(), href = subHeadLines[i].ChildNodes["a"].Attributes["href"].Value };
            //    HeadLines.Add(data);
            //}

            //string SerializedData = JsonConvert.SerializeObject(HeadLines);
            //return SerializedData;

            return HeadLines;
        }
    }
}
