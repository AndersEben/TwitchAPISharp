using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCondition
    {
        [JsonProperty]
        public string broadcaster_user_id { get; internal set; }
        [JsonProperty]
        public string from_broadcaster_user_id { get; internal set; }
        [JsonProperty]
        public string to_broadcaster_user_id { get; internal set; }
        [JsonProperty]
        public string reward_id { get; internal set; }
        [JsonProperty]
        public string organization_id { get; internal set; }
        [JsonProperty]
        public string category_id { get; internal set; }
        [JsonProperty]
        public string campaign_id { get; internal set; }
        [JsonProperty]
        public string extension_client_id { get; internal set; }
        [JsonProperty]
        public string client_id { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
    }
}
