using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetHypeTrainEventsData : TemplateResponseData<ResponseGetHypeTrainEvents>
    {

    }

    public class ResponseGetHypeTrainEvents
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string event_type { get; internal set; }
        [JsonProperty]
        public string event_timestamp { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
        [JsonProperty]
        public ResponseEventData event_data { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
    }
}
