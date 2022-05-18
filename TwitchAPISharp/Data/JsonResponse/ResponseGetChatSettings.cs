using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetChatSettingsData : TemplateResponseData<ResponseGetChatSettings>
    {

    }

    public class ResponseGetChatSettings
    {
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public bool emote_mode { get; internal set; }
        [JsonProperty]
        public bool follower_mode { get; internal set; }
        [JsonProperty]
        public int follower_mode_duration { get; internal set; }
        [JsonProperty]
        public bool non_moderator_chat_delay { get; internal set; }
        [JsonProperty]
        public int non_moderator_chat_delay_duration { get; internal set; }
        [JsonProperty]
        public bool slow_mode { get; internal set; }
        [JsonProperty]
        public int slow_mode_wait_time { get; internal set; }
        [JsonProperty]
        public bool subscriber_mode { get; internal set; }
        [JsonProperty]
        public bool unique_chat_mode { get; internal set; }
    }
}
