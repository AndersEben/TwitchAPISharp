using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseVacation
    {
        [JsonProperty]
        public string start_time { get; internal set; }
        [JsonProperty]
        public string end_time { get; internal set; }
    }
}
