using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetExtensionLiveChannelsData : TemplateResponseData<ResponseGetExtensionLiveChannels>
    {

    }

    public class ResponseGetExtensionLiveChannels
    {
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string game_name { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
    }
}
