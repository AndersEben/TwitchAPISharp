using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCheckUserSubscriptionData : TemplateResponseData<ResponseCheckUserSubscription>
    {

    }

    public class ResponseCheckUserSubscription
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public bool is_gift { get; internal set; }
        [JsonProperty]
        public string gifter_login { get; internal set; }
        [JsonProperty]
        public string gifter_name { get; internal set; }
        [JsonProperty]
        public string tier { get; internal set; }
    }
}
