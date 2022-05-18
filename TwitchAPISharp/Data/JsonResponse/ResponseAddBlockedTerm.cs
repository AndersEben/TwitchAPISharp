using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseAddBlockedTermData : TemplateResponseData<ResponseAddBlockedTerm>
    {
    }

    public class ResponseAddBlockedTerm
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public string expires_at { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string moderator_id { get; internal set; }
        [JsonProperty]
        public string text { get; internal set; }
        [JsonProperty]
        public string updated_at { get; internal set; }
    }
}
