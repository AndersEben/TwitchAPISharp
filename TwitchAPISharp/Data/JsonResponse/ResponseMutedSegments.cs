using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseMutedSegments
    {
        [JsonProperty]
        public int duration { get; internal set; }
        [JsonProperty]
        public int offset { get; internal set; }
    }
}
