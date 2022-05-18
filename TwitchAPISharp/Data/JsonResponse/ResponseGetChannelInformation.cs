using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetChannelInformationData : TemplateResponseData<ResponseGetChannelInformation>
    {

    }

    public class ResponseGetChannelInformation
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string game_name { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_language { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public int delay { get; internal set; }

    }
}
