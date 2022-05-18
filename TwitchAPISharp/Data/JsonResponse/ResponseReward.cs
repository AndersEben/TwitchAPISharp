using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseReward
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string prompt { get; internal set; }
        [JsonProperty]
        public int cost { get; internal set; }
    }
}
