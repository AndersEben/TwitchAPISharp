using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseUpdateDropsEntitlementsData : TemplateResponseData<ResponseUpdateDropsEntitlements>
    {
    }

    public class ResponseUpdateDropsEntitlements
    {
        [JsonProperty]
        public string status { get; internal set; }
        [JsonProperty]
        public List<string> ids { get; internal set; }
    }
}
