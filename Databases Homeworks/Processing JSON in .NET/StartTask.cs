using System;
using System.Linq;
using System.Net;
namespace TelerikRss
{
    class StartTask
    {
        static void Main(string[] args)
        {
            var downloadUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var filePath = "../../rssFeed.xml";
            WebClient myWebClient = new WebClient();

            Utils.GetRss(myWebClient, downloadUrl, filePath);
            var rssAsJsonObject = Utils.GetJsonObjectFromXmlFileUrl(filePath);
            var videos = Utils.GetVideos(rssAsJsonObject);

            Utils.PrintVideoTitles(videos);

            var html = Utils.GetHtml(videos);
            Utils.SaveHtml(html, "videos.html");
        }
    }
}
