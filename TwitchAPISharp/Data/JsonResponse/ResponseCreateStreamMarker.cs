using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCreateStreamMarkerData : TemplateResponseData<ResponseCreateStreamMarker>
    {

    }

    public class ResponseCreateStreamMarker
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
        [JsonProperty]
        public int position_seconds { get; internal set; }
        [JsonProperty]
        public int created_at { get; internal set; }
    }
}
