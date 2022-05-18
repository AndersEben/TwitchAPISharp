using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetExtensionConfigurationSegmentData : TemplateResponseData<ResponseGetExtensionConfigurationSegment>
    {
    }

    public class ResponseGetExtensionConfigurationSegment
    {
        [JsonProperty]
        public string segment { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string content { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
    }
}
