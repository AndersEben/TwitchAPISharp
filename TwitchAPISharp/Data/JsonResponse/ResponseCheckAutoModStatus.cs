using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCheckAutoModStatusData : TemplateResponseData<ResponseCheckAutoModStatus>
    {

    }

    public class ResponseCheckAutoModStatus
    {
        [JsonProperty]
        public string msg_id { get; internal set; }
        [JsonProperty]
        public bool is_permitted { get; internal set; }
    }
}
