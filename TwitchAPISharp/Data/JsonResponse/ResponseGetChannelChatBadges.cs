using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetChannelChatBadgesData : TemplateResponseData<ResponseGetChannelChatBadges>
    {

    }

    public class ResponseGetChannelChatBadges
    {
        [JsonProperty]
        public string set_id { get; internal set; }
        [JsonProperty]
        public List<ResponseGetChannelChatBadgesVersion> versions { get; internal set; }
    }

    public class ResponseGetChannelChatBadgesVersion
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string image_url_1x { get; internal set; }
        [JsonProperty]
        public string image_url_2x { get; internal set; }
        [JsonProperty]
        public string image_url_4x { get; internal set; }
    }
}
