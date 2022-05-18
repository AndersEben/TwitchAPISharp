using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseEmoteTemplate
    {
        [JsonProperty]
        public string template { get; internal set; }
    }
}
