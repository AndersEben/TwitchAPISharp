using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetCustomRewardData : TemplateResponseData<ResponseGetCustomReward>
    {

    }

    public class ResponseGetCustomReward
    {
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public CustImages image { get; internal set; }
        [JsonProperty]
        public string background_color { get; internal set; }
        [JsonProperty]
        public bool is_enabled { get; internal set; }
        [JsonProperty]
        public int cost { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string prompt { get; internal set; }
        [JsonProperty]
        public bool is_user_input_required { get; internal set; }

        [JsonProperty]
        public max_per_stream_setting max_per_stream_setting { get; internal set; }
        [JsonProperty]
        public max_per_user_per_stream_setting max_per_user_per_stream_setting { get; internal set; }
        [JsonProperty]
        public global_cooldown_setting global_cooldown_setting { get; internal set; }

        [JsonProperty]
        public bool is_paused { get; internal set; }
        [JsonProperty]
        public bool is_in_stock { get; internal set; }
        [JsonProperty]
        public CustImages default_image { get; internal set; }
        [JsonProperty]
        public bool should_redemptions_skip_request_queue { get; internal set; }
        [JsonProperty]
        public int redemptions_redeemed_current_stream { get; internal set; }
        [JsonProperty]
        public string cooldown_expires_at { get; internal set; }
    }
}
