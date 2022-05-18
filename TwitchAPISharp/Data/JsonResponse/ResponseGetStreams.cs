using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetStreamsData : TemplateResponseData<ResponseGetStreams>
    {

    }

    public class ResponseGetStreams
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string game_name { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public int viewer_count { get; internal set; }
        [JsonProperty]
        public string started_at { get; internal set; }
        [JsonProperty]
        public string language { get; internal set; }
        [JsonProperty]
        public string thumbnail_url { get; internal set; }
        [JsonProperty]
        public List<string> tag_ids { get; internal set; }
        [JsonProperty]
        public bool is_mature { get; internal set; }
    }
}
