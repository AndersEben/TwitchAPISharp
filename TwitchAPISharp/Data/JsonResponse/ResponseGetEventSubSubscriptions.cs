using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetEventSubSubscriptionsData : TemplateResponseData<ResponseGetEventSubSubscriptions>
    {
        [JsonProperty]
        public int total { get; internal set; }
        [JsonProperty]
        public int total_cost { get; internal set; }
        [JsonProperty]
        public int max_total_cost { get; internal set; }

    }

    public class ResponseGetEventSubSubscriptions
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string status { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
        [JsonProperty]
        public ResponseCondition condition { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public ResponseTransport transport { get; internal set; }
        [JsonProperty]
        public int cost { get; internal set; }
    }
}
