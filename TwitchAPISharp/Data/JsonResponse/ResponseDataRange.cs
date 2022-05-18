using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseDataRange
    {
        [JsonProperty]
        public string start_at { get; internal set; }
        [JsonProperty]
        public string ended_at { get; internal set; }

    }
}
