using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseSearchChannelsData : TemplateResponseData<ResponseSearchChannels>
    {

    }

    public class ResponseSearchChannels
    {
        [JsonProperty]
        public string broadcaster_language { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string display_name { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string game_name { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public bool is_live { get; internal set; }
        [JsonProperty]
        public List<string> tag_ids { get; internal set; }
        [JsonProperty]
        public string thumbnail_url { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string started_at { get; internal set; }
    }
}
