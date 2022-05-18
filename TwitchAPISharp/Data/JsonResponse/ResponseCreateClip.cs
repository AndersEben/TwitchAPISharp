using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCreateClipData : TemplateResponseData<ResponseCreateClip>
    {

    }

    public class ResponseCreateClip
    {
        [JsonProperty]
        public string edit_url { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
    }
}
