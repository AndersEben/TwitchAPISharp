using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class max_per_stream_setting
    {
        [JsonProperty]
        public bool is_enabled { get; internal set; }
        [JsonProperty]
        public int max_per_stream { get; internal set; }
    }

    public class max_per_user_per_stream_setting
    {
        [JsonProperty]
        public string is_enabled { get; internal set; }
        [JsonProperty]
        public string max_per_user_per_stream { get; internal set; }
    }

    public class global_cooldown_setting
    {
        [JsonProperty]
        public string is_enabled { get; internal set; }
        [JsonProperty]
        public string global_cooldown_seconds { get; internal set; }
    }
}
