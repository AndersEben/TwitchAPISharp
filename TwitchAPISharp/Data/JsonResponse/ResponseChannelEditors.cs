using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseChannelEditorsData : TemplateResponseData<ResponseChannelEditors>
    {

    }

    public class ResponseChannelEditors
    {
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
    }
}
