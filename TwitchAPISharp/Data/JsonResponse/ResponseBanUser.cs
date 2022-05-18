using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseBanUserData : TemplateResponseData<ResponseBanUser>
    {

    }

    public class ResponseBanUser
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string end_time { get; internal set; }
        [JsonProperty]
        public string moderator_id { get; internal set; }
        [JsonProperty]
        public string user_id { get; internal set; }
    }
}
