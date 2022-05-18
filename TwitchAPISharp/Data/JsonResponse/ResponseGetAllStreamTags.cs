using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetAllStreamTagsData : TemplateResponseData<ResponseGetAllStreamTags>
    {

    }

    public class ResponseGetAllStreamTags
    {
        [JsonProperty]
        public string tag_id { get; internal set; }
        [JsonProperty]
        public bool is_auto { get; internal set; }
        [JsonProperty]
        public ResponseGetAllStreamTagsLocalizationNames localization_names { get; internal set; }
        [JsonProperty]
        public ResponseGetAllStreamTagsLocalizationDescriptions localization_descriptions { get; internal set; }
    }

    public class ResponseGetAllStreamTagsLocalizationNames
    {
        [JsonProperty("bg-bg")]
        public string bg_bg { get; internal set; }
        [JsonProperty("cs-cz")]
        public string cs_cz { get; internal set; }
        [JsonProperty("da-dk")]
        public string da_dk { get; internal set; }
        [JsonProperty("de-de")]
        public string de_de { get; internal set; }
        [JsonProperty("el-gr")]
        public string el_gr { get; internal set; }
        [JsonProperty("en-us")]
        public string en_us { get; internal set; }
    }

    public class ResponseGetAllStreamTagsLocalizationDescriptions
    {
        [JsonProperty("bg-bg")]
        public string bg_bg { get; internal set; }
        [JsonProperty("cs-cz")]
        public string cs_cz { get; internal set; }
        [JsonProperty("da-dk")]
        public string da_dk { get; internal set; }
        [JsonProperty("de-de")]
        public string de_de { get; internal set; }
        [JsonProperty("el-gr")]
        public string el_gr { get; internal set; }
        [JsonProperty("en-us")]
        public string en_us { get; internal set; }
    }
}
