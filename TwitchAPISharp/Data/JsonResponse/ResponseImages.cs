using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseImages
    {
        [JsonProperty]
        public ResponseImagesDark dark { get; internal set; }
        [JsonProperty]
        public ResponseImagesLight light { get; internal set; }

    }

    public class ResponseImagesDark
    {
        [JsonProperty]
        public ResponseImagesAnimated animated { get; internal set; }

        [JsonProperty("static")]
        public ResponseImagesStatic statisch { get; internal set; }

    }

    public class ResponseImagesLight
    {
        [JsonProperty]
        public ResponseImagesAnimated animated { get; internal set; }

        [JsonProperty("static")]
        public ResponseImagesStatic statisch { get; internal set; }

    }

    public class ResponseImagesAnimated
    {
        [JsonProperty("1")]
        public string one { get; internal set; }
        [JsonProperty("1.5")]
        public string onepfive { get; internal set; }
        [JsonProperty("2")]
        public string two { get; internal set; }
        [JsonProperty("3")]
        public string three { get; internal set; }
        [JsonProperty("4")]
        public string four { get; internal set; }

    }

    public class ResponseImagesStatic
    {
        [JsonProperty("1")]
        public string one { get; internal set; }
        [JsonProperty("1.5")]
        public string onepfive { get; internal set; }
        [JsonProperty("2")]
        public string two { get; internal set; }
        [JsonProperty("3")]
        public string three { get; internal set; }
        [JsonProperty("4")]
        public string four { get; internal set; }

    }

    public class CustImages
    {
        [JsonProperty]
        public string url_1x { get; internal set; }
        [JsonProperty]
        public string url_2x { get; internal set; }
        [JsonProperty]
        public string url_4x { get; internal set; }
    }
}
