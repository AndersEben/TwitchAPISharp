using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetCustomRewardRedemptionData : TemplateResponseData<ResponseGetCustomRewardRedemption>
    {

    }

    public class ResponseGetCustomRewardRedemption
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string user_input { get; internal set; }
        [JsonProperty]
        public ResponseReward reward { get; internal set; }
        [JsonProperty]
        public string status { get; internal set; }
        [JsonProperty]
        public string redeemed_at { get; internal set; }
    }
}
