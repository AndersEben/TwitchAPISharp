using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetUsersData : TemplateResponseData<ResponseGetUsers>
    {

    }

    public class ResponseGetUsers
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string login { get; internal set; }
        [JsonProperty]
        public string display_name { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public string broadcaster_type { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public string profile_image_url { get; internal set; }
        [JsonProperty]
        public string offline_image_url { get; internal set; }
        [JsonProperty]
        public int view_count { get; internal set; }
        [JsonProperty]
        public string email { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
    }
}
