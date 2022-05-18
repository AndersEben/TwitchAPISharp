using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseSegments
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string start_time { get; internal set; }
        [JsonProperty]
        public string end_time { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string canceled_until { get; internal set; }
        [JsonProperty]
        public ResponseSegmentsCategory category { get; internal set; }
    }

    public class ResponseSegmentsCategory
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
    }
}
