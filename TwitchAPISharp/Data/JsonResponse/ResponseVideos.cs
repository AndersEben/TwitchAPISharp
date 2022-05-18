using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseVideos
    {
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public List<ResponseVideosMarkers> markers { get; internal set; }
    }

    public class ResponseVideosMarkers
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public int position_seconds { get; internal set; }
        [JsonProperty]
        public string URL { get; internal set; }
    }
}
