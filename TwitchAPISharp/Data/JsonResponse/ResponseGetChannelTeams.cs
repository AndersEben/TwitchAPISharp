using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetChannelTeamsData : TemplateResponseData<ResponseGetChannelTeams>
    {

    }

    public class ResponseGetChannelTeams
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string background_image_url { get; internal set; }
        [JsonProperty]
        public string banner { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public string updated_at { get; internal set; }
        [JsonProperty]
        public string info { get; internal set; }
        [JsonProperty]
        public string thumbnail_url { get; internal set; }
        [JsonProperty]
        public string team_name { get; internal set; }
        [JsonProperty]
        public string team_display_name { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
    }
}
