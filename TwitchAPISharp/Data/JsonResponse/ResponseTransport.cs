using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseTransport
    {
        [JsonProperty]
        public string method { get; internal set; }
        [JsonProperty]
        public string callback { get; internal set; }
    }
}
