using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetAutoModSettingsData : TemplateResponseData<ResponseGetAutoModSettings>
    {

    }

    public class ResponseGetAutoModSettings
    {
        [JsonProperty]
        public int aggression { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public int bullying { get; internal set; }
        [JsonProperty]
        public int disability { get; internal set; }
        [JsonProperty]
        public int misogyny { get; internal set; }
        [JsonProperty]
        public string moderator_id { get; internal set; }
        [JsonProperty]
        public int overall_level { get; internal set; }
        [JsonProperty]
        public int race_ethnicity_or_religion { get; internal set; }
        [JsonProperty]
        public int sex_based_terms { get; internal set; }
        [JsonProperty]
        public int sexuality_sex_or_gender { get; internal set; }
        [JsonProperty]
        public int swearing { get; internal set; }
    }
}
