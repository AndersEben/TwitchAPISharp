using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetExtensionTransactionsData : TemplateResponseData<ResponseGetExtensionTransactions>
    {

    }

    public class ResponseGetExtensionTransactions
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string timestamp { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }

        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
        [JsonProperty]
        public string product_type { get; internal set; }
        [JsonProperty]
        public ResponseProductData product_data { get; internal set; }

    }
}
