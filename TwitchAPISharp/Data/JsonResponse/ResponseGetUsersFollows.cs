using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetUsersFollowsData : TemplateResponseData<ResponseGetUsersFollows>
    {
        [JsonProperty]
        public int total { get; internal set; }
    }

    public class ResponseGetUsersFollows
    {
        [JsonProperty]
        public string from_id { get; internal set; }
        [JsonProperty]
        public string from_login { get; internal set; }
        [JsonProperty]
        public string from_name { get; internal set; }
        [JsonProperty]
        public string to_id { get; internal set; }
        [JsonProperty]
        public string to_name { get; internal set; }
        [JsonProperty]
        public string followed_at { get; internal set; }
    }
}
