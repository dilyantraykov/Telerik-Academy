using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TelerikRss
{
    using System;
    using System.Net;

    public static class Utils
    {
        public static void GetRss(WebClient myWebClient, string downloadUrl, string filePath)
        {
            Console.WriteLine("Downloading Telerik RSS feed...");
            myWebClient.DownloadFile(downloadUrl, filePath);
            Console.WriteLine("Feed successfully downloaded!");
            Console.WriteLine();
        }

        public static JObject GetJsonObjectFromXmlFileUrl(string filePath)
        {
            var doc = XDocument.Load(filePath);
            var rssAsJson = JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);

            return JObject.Parse(rssAsJson);
        }

        public static IEnumerable<Video> GetVideos(JObject jsonObject)
        {
            var videos = jsonObject["feed"]["entry"]
                .Select(x => JsonConvert.DeserializeObject<Video>(x.ToString()));

            return videos;
        }

        public static void PrintVideoTitles(IEnumerable<Video> videos)
        {
            Console.WriteLine("List of video titles in the feed:");
            var index = 1;
            videos.Select(x => string.Format("{0}) {1}", index++, x.Title)).Print();
            Console.WriteLine();
        }

        public static string GetHtml(IEnumerable<Video> videos)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><head><link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\" /></head><body>");
            foreach (var video in videos)
            {
                html.AppendFormat("<div class=\"video-container\">" +
                                  "<h3><a class=\"video-title\" href=\"{0}\">{2}</a></h3>" +
                                  "<iframe class=\"video-frame\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "</div>",
                                  video.Link.Href, video.Id, video.Title);
            }
            html.Append("</body></html>");

            return html.ToString();
        }

        public static void SaveHtml(string html, string htmlName)
        {
            using (StreamWriter writer = new StreamWriter("../../" + htmlName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }

            Console.WriteLine("Videos saved at {0}", htmlName);
        }
    }
}
