using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseSource
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string content_type { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string image_url { get; internal set; }
        [JsonProperty]
        public string soundtrack_url { get; internal set; }
        [JsonProperty]
        public string spotify_url { get; internal set; }
    }
}
