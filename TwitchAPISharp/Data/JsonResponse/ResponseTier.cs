using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseTier
    {
        [JsonProperty]
        public int min_bits { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string color { get; internal set; }
        [JsonProperty]
        public ResponseImages images { get; internal set; }
        [JsonProperty]
        public bool can_cheer { get; internal set; }
        [JsonProperty]
        public bool show_in_bits_card { get; internal set; }

    }
}
