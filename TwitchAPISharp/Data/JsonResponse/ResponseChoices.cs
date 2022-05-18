using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseChoices
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public int votes { get; internal set; }
        [JsonProperty]
        public int channel_points_votes { get; internal set; }
        [JsonProperty]
        public int bits_votes { get; internal set; }
    }
}
