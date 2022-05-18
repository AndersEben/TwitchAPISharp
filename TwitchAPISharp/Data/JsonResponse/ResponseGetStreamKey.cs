using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetStreamKeyData : TemplateResponseData<ResponseGetStreamKey>
    {

    }

    public class ResponseGetStreamKey
    {
        [JsonProperty]
        public string stream_key { get; internal set; }
    }
}
