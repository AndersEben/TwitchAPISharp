using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetStreamTagsData : TemplateResponseData<ResponseGetStreamTags>
    {

    }

    public class ResponseGetStreamTags
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
}
