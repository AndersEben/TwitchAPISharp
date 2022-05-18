using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseTopPredictors
    {
        [JsonProperty]
        public ResponseUser user { get; internal set; }
    }
}
