using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCost
    {
        [JsonProperty]
        public int amount { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
    }
}
