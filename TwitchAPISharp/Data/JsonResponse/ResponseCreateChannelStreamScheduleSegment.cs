using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCreateChannelStreamScheduleSegmentData : TemplateResponseData<ResponseCreateChannelStreamScheduleSegment>
    {

    }

    public class ResponseCreateChannelStreamScheduleSegment
    {
        [JsonProperty]
        public List<ResponseSegments> segments { get; internal set; }
        [JsonProperty]
        public bool is_recurring { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public ResponseVacation vacation { get; internal set; }
    }
}
