using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetStreamMarkersData : TemplateResponseData<ResponseGetStreamMarkers>
    {

    }

    public class ResponseGetStreamMarkers
    {
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public int user_login { get; internal set; }
        [JsonProperty]
        public List<ResponseVideos> videos { get; internal set; }
    }
}
