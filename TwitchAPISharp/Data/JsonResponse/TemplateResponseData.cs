using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class TemplateResponseData<T>
    {
        [JsonProperty]
        public List<T> data { get; internal set; }


        [JsonProperty]
        public string error { get; internal set; }
        [JsonProperty]
        public int status { get; internal set; }
        [JsonProperty]
        public string message { get; internal set; }


        [JsonProperty]
        public ResponsePagination pagination { get; internal set; }
    }
}
