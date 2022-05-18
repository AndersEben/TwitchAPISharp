using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetUserActiveExtensionsData : TemplateResponseData<ResponseGetUserActiveExtensions>
    {

    }

    public class ResponseGetUserActiveExtensions
    {
        [JsonProperty]
        public ResponseGetUserActiveExtensionsPanel panel { get; internal set; }
        [JsonProperty]
        public ResponseGetUserActiveExtensionsPanel overlay { get; internal set; }
        [JsonProperty]
        public ResponseGetUserActiveExtensionsPanel component { get; internal set; }
    }

    public class ResponseGetUserActiveExtensionsPanel
    {
        [JsonProperty("1")]
        public ResponseGetUserActiveExtensionsADDData one { get; internal set; }
        [JsonProperty("2")]
        public ResponseGetUserActiveExtensionsADDData two { get; internal set; }
        [JsonProperty("3")]
        public ResponseGetUserActiveExtensionsADDData three { get; internal set; }
        [JsonProperty("4")]
        public ResponseGetUserActiveExtensionsADDData four { get; internal set; }
        [JsonProperty("5")]
        public ResponseGetUserActiveExtensionsADDData five { get; internal set; }
    }

    public class ResponseGetUserActiveExtensionsOverlay
    {
        [JsonProperty("1")]
        public ResponseGetUserActiveExtensionsADDData one { get; internal set; }
        [JsonProperty("2")]
        public ResponseGetUserActiveExtensionsADDData two { get; internal set; }
        [JsonProperty("3")]
        public ResponseGetUserActiveExtensionsADDData three { get; internal set; }
        [JsonProperty("4")]
        public ResponseGetUserActiveExtensionsADDData four { get; internal set; }
        [JsonProperty("5")]
        public ResponseGetUserActiveExtensionsADDData five { get; internal set; }
    }

    public class ResponseGetUserActiveExtensionsComponent
    {
        [JsonProperty("1")]
        public ResponseGetUserActiveExtensionsADDData one { get; internal set; }
        [JsonProperty("2")]
        public ResponseGetUserActiveExtensionsADDData two { get; internal set; }
        [JsonProperty("3")]
        public ResponseGetUserActiveExtensionsADDData three { get; internal set; }
        [JsonProperty("4")]
        public ResponseGetUserActiveExtensionsADDData four { get; internal set; }
        [JsonProperty("5")]
        public ResponseGetUserActiveExtensionsADDData five { get; internal set; }
    }

    public class ResponseGetUserActiveExtensionsADDData
    {
        [JsonProperty]
        public bool active { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string version { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string x { get; internal set; }
        [JsonProperty]
        public string y { get; internal set; }
    }
}
