using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetExtensionSecretsData : TemplateResponseData<ResponseGetExtensionSecrets>
    {
    }

    public class ResponseGetExtensionSecrets
    {
        [JsonProperty]
        public int format_version { get; internal set; }
        [JsonProperty]
        public ResponseSecrets secrets { get; internal set; }
    }
}
