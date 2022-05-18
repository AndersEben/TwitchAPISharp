using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetReleasedExtensionsData : TemplateResponseData<ResponseGetReleasedExtensions>
    {

    }

    public class ResponseGetReleasedExtensions
    {
        [JsonProperty]
        public string author_name { get; internal set; }
        [JsonProperty]
        public bool bits_enabled { get; internal set; }
        [JsonProperty]
        public bool can_install { get; internal set; }
        [JsonProperty]
        public string configuration_location { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public string eula_tos_url { get; internal set; }
        [JsonProperty]
        public bool has_chat_support { get; internal set; }
        [JsonProperty]
        public string icon_url { get; internal set; }
        [JsonProperty]
        public ResponseIconUrls icon_urls { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string privacy_policy_url { get; internal set; }
        [JsonProperty]
        public bool request_identity_link { get; internal set; }
        [JsonProperty]
        public List<string> screenshot_urls { get; internal set; }
        [JsonProperty]
        public string state { get; internal set; }
        [JsonProperty]
        public string subscriptions_support_level { get; internal set; }
        [JsonProperty]
        public string summary { get; internal set; }
        [JsonProperty]
        public string support_email { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
        [JsonProperty]
        public string viewer_summary { get; internal set; }
        [JsonProperty]
        public ResponseViews views { get; internal set; }
        [JsonProperty]
        public List<string> allowlisted_config_urls { get; internal set; }
        [JsonProperty]
        public List<string> allowlisted_panel_urls { get; internal set; }
    }
}
