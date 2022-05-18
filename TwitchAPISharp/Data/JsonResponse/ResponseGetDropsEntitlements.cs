using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetDropsEntitlementsData : TemplateResponseData<ResponseGetDropsEntitlements>
    {

    }

    public class ResponseGetDropsEntitlements
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string benefit_id { get; internal set; }
        [JsonProperty]
        public string timestamp { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string fulfillment_status { get; internal set; }
        [JsonProperty]
        public string updated_at { get; internal set; }
    }
}
