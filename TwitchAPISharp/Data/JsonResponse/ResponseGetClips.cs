using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetClipsData : TemplateResponseData<ResponseGetClips>
    {

    }
    public class ResponseGetClips
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string url { get; internal set; }
        [JsonProperty]
        public string embed_url { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string creator_id { get; internal set; }
        [JsonProperty]
        public string creator_name { get; internal set; }
        [JsonProperty]
        public string video_id { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string language { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public int view_count { get; internal set; }
        [JsonProperty]
        public string rcreated_atank { get; internal set; }
        [JsonProperty]
        public string thumbnail_url { get; internal set; }
        [JsonProperty]
        public float duration { get; internal set; }

    }
}
