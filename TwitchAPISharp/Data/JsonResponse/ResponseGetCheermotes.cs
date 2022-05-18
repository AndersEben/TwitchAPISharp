using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetCheermotesData : TemplateResponseData<ResponseGetCheermotes>
    {

    }

    public class ResponseGetCheermotes
    {
        [JsonProperty]
        public string prefix { get; internal set; }
        [JsonProperty]
        public List<ResponseTier> tiers { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }
        [JsonProperty]
        public int order { get; internal set; }
        [JsonProperty]
        public string last_update { get; internal set; }
        [JsonProperty]
        public bool is_charitable { get; internal set; }

    }
}
