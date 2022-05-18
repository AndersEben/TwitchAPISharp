using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseEventData
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string started_at { get; internal set; }
        [JsonProperty]
        public string expires_at { get; internal set; }
        [JsonProperty]
        public string cooldown_end_time { get; internal set; }
        [JsonProperty]
        public int level { get; internal set; }
        [JsonProperty]
        public int goal { get; internal set; }
        [JsonProperty]
        public int total { get; internal set; }
        [JsonProperty]
        public ResponseTopContributions top_contributions { get; internal set; }
        [JsonProperty]
        public List<ResponseLastContribution> last_contribution { get; internal set; }
    }

    public class ResponseTopContributions
    {
        [JsonProperty]
        public int total { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string user { get; internal set; }
    }

    public class ResponseLastContribution
    {
        [JsonProperty]
        public int total { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string user { get; internal set; }
    }
}
