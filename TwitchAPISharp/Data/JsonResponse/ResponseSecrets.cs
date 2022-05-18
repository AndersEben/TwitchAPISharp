using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseSecrets
    {
        [JsonProperty]
        public string content { get; internal set; }
        [JsonProperty]
        public string active_at { get; internal set; }
        [JsonProperty]
        public string expires_at { get; internal set; }
    }
}
