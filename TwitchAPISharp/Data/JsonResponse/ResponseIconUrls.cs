using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseIconUrls
    {
        [JsonProperty("100x100")]
        public string hundert { get; internal set; }
        [JsonProperty("24x24")]
        public string twentyfour { get; internal set; }
        [JsonProperty("300x200")]
        public string threehundert { get; internal set; }
    }
}
