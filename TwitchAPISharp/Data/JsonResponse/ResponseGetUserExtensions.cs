using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetUserExtensionsData : TemplateResponseData<ResponseGetUserExtensions>
    {

    }

    public class ResponseGetUserExtensions
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public bool can_activate { get; internal set; }
        [JsonProperty]
        public List<string> type { get; internal set; }
    }
}
