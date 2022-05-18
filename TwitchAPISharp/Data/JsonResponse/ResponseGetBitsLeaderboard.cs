using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetBitsLeaderboardData : TemplateResponseData<ResponseGetBitsLeaderboard>
    {
        [JsonProperty]
        public ResponseDataRange data_range { get; internal set; }
        [JsonProperty]
        public int total { get; internal set; }
    }
    public class ResponseGetBitsLeaderboard
    {
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public int rank { get; internal set; }
        [JsonProperty]
        public int score { get; internal set; }
    }
}
