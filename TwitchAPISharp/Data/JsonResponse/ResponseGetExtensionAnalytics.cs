using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{

    public class ResponseGetExtensionAnalyticsData : TemplateResponseData<ResponseGetExtensionAnalytics>
    {

    }

    public class ResponseGetExtensionAnalytics
    {
        [JsonProperty]
        public string extension_id { get; internal set; }
        [JsonProperty]
        public string URL { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }

        public ResponseDataRange data_range { get; internal set; }

    }
}
