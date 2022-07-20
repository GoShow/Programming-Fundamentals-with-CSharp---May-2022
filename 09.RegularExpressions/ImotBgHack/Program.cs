using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> pricesByArea = new Dictionary<string, List<int>>();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (WebClient client = new WebClient { Encoding = System.Text.Encoding.UTF8 })
            {
                for (int i = 1; i < 25; i++)
                {
                    string htmlCode = GetHtml(client, i);

                    MatchCollection matches = Regex.Matches(htmlCode, @"<div class=""price"">(?:<img.*?>)?(?<price>.*?)<.*?<a.*?<a.*?>(?<area>.*?)<", RegexOptions.Singleline);

                    foreach (Match item in matches)
                    {
                        string[] tokens = item.Groups["price"].Value.Split("EUR", StringSplitOptions.RemoveEmptyEntries);
                        string priceStr = tokens[0].Trim().Replace(" ", "");
                        if (int.TryParse(priceStr, out int price))
                        {
                            string area = item.Groups["area"].Value;

                            if (!pricesByArea.ContainsKey(area))
                            {
                                pricesByArea.Add(area, new List<int>());
                            }

                            pricesByArea[area].Add(price);

                        }

                        Console.WriteLine($"Area: {item.Groups["area"].Value}, Price: {item.Groups["price"].Value}");
                    }
                }
            }

            Console.WriteLine();

            foreach (var item in pricesByArea)
            {
                Console.WriteLine($"Area: {item.Key}, Average price: {item.Value.Average()}, Count: {item.Value.Count}");
            }
        }

        private static string GetHtml(WebClient client, int index)
        {
            byte[] content = client.DownloadData(@$"https://www.imot.bg/pcgi/imot.cgi?act=3&slink=88o5rs&f1={index}");
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding1251 = Encoding.GetEncoding("windows-1251");
            var convertedBytes = Encoding.Convert(encoding1251, Encoding.UTF8, content);

            string htmlCode = Encoding.UTF8.GetString(convertedBytes);

            return htmlCode;
        }
    }
}