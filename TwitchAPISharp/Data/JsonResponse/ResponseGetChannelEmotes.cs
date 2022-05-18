using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetChannelEmotesData : TemplateResponseData<ResponseGetChannelEmotes>
    {
        [JsonProperty]
        public string template { get; internal set; }
    }
    public class ResponseGetChannelEmotes
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public CustImages images { get; internal set; }
        [JsonProperty]
        public string tier { get; internal set; }
        [JsonProperty]
        public string emote_type { get; internal set; }
        [JsonProperty]
        public string emote_set_id { get; internal set; }
        [JsonProperty]
        public List<string> format { get; internal set; }
        [JsonProperty]
        public List<string> scale { get; internal set; }
        [JsonProperty]
        public List<string> theme_mode { get; internal set; }
    }
}
