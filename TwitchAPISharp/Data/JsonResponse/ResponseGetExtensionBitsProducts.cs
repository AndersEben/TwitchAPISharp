using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetExtensionBitsProductsData : TemplateResponseData<ResponseGetExtensionBitsProducts>
    {

    }

    public class ResponseGetExtensionBitsProducts
    {
        [JsonProperty]
        public string sku { get; internal set; }
        [JsonProperty]
        public ResponseCost cost { get; internal set; }
        [JsonProperty]
        public bool in_development { get; internal set; }
        [JsonProperty]
        public string display_name { get; internal set; }
        [JsonProperty]
        public string expiration { get; internal set; }
        [JsonProperty]
        public bool is_broadcast { get; internal set; }
    }
}
