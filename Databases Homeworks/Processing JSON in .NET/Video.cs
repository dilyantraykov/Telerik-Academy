using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TelerikRss
{
    public class Video
    {
        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }
    }
}
