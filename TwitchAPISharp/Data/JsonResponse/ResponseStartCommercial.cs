using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseStartCommercialData : TemplateResponseData<ResponseStartCommercial>
    {

    }
    public class ResponseStartCommercial
    {
        [JsonProperty]
        public int length { get; internal set; }
        [JsonProperty]
        public string message { get; internal set; }
        [JsonProperty]
        public int retry_after { get; internal set; }

    }
}
