using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetCodeStatusData :  TemplateResponseData<ResponseGetCodeStatus>
    {
    }

    public class ResponseGetCodeStatus
    {
        [JsonProperty]
        public string code { get; internal set; }
        [JsonProperty]
        public string status { get; internal set; }
    }
}
