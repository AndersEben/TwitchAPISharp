using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetBroadcasterSubscriptionsData : TemplateResponseData<ResponseGetBroadcasterSubscriptions>
    {
        [JsonProperty]
        public int total { get; internal set; }
        [JsonProperty]
        public int points { get; internal set; }
    }

    public class ResponseGetBroadcasterSubscriptions
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public int gifter_id { get; internal set; }
        [JsonProperty]
        public string gifter_login { get; internal set; }
        [JsonProperty]
        public string gifter_name { get; internal set; }
        [JsonProperty]
        public bool is_gift { get; internal set; }
        [JsonProperty]
        public string plan_name { get; internal set; }
        [JsonProperty]
        public string tier { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }

    }
}
