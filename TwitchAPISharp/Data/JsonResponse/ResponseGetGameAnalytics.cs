using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetGameAnalyticssData : TemplateResponseData<ResponseGetGameAnalytics>
    {

    }
    public class ResponseGetGameAnalytics
    {
        [JsonProperty]
        public string game_id { get; internal set; }
        [JsonProperty]
        public string URL { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }

        [JsonProperty]
        public ResponseDataRange data_range { get; internal set; }

    }
}
