using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetGlobalChatBadgesData : TemplateResponseData<ResponseGetGlobalChatBadges>
    {

    }

    public class ResponseGetGlobalChatBadges
    {
        [JsonProperty]
        public string set_id { get; internal set; }
        [JsonProperty]
        public List<ResponseGetGlobalChatBadgesVersion> versions { get; internal set; }
    }

    public class ResponseGetGlobalChatBadgesVersion
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
