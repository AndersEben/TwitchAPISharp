using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseProductData
    {
        [JsonProperty]
        public string domain { get; internal set; }
        [JsonProperty]
        public string sku { get; internal set; }
        [JsonProperty]
        public ResponseProductDataCost cost { get; internal set; }
        [JsonProperty]
        public string displayName { get; internal set; }
        [JsonProperty]
        public string expiration { get; internal set; }
        [JsonProperty]
        public bool broadcast { get; internal set; }

    }

    public class ResponseProductDataCost
    {
        [JsonProperty]
        public int ammount { get; internal set; }
        [JsonProperty]
        public string type { get; internal set; }

    }

}
