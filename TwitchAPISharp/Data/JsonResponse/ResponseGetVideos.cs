using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetVideosData : TemplateResponseData<ResponseGetVideos>
    {

    }

    public class ResponseGetVideos
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string stream_id { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public string published_at { get; internal set; }
        [JsonProperty]
        public string url { get; internal set; }
        [JsonProperty]
        public string thumbnail_url { get; internal set; }
        [JsonProperty]
        public string viewable { get; internal set; }
        [JsonProperty]
        public int view_count { get; internal set; }
        [JsonProperty]
        public string language { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string duration { get; internal set; }
        [JsonProperty]
        public List<ResponseMutedSegments> muted_segments { get; internal set; }
    }
}
