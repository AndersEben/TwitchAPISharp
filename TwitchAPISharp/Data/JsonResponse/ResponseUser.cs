using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseUser
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string login { get; internal set; }
        [JsonProperty]
        public int channel_points_used { get; internal set; }
        [JsonProperty]
        public int channel_points_won { get; internal set; }
    }
}
