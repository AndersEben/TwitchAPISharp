using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetCreatorGoalsData : TemplateResponseData<ResponseGetCreatorGoals>
    {

    }

    public class ResponseGetCreatorGoals
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public int current_amount { get; internal set; }
        [JsonProperty]
        public int target_amount { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
    }
}
