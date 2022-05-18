using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCreatePredictionData : TemplateResponseData<ResponseCreatePrediction>
    {

    }

    public class ResponseCreatePrediction
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string broadcaster_id { get; internal set; }
        [JsonProperty]
        public string broadcaster_name { get; internal set; }
        [JsonProperty]
        public string broadcaster_login { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string winning_outcome_id { get; internal set; }
        [JsonProperty]
        public List<ResponseOutcomes> outcomes { get; internal set; }
        [JsonProperty]
        public int prediction_window { get; internal set; }
        [JsonProperty]
        public string status { get; internal set; }
        [JsonProperty]
        public string created_at { get; internal set; }
        [JsonProperty]
        public string ended_at { get; internal set; }
        [JsonProperty]
        public string locked_at { get; internal set; }
    }
}
