using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseOutcomes
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public int users { get; internal set; }
        [JsonProperty]
        public int channel_points { get; internal set; }
        [JsonProperty]
        public List<ResponseTopPredictors> top_predictors { get; internal set; }
        [JsonProperty]
        public string color { get; internal set; }
    }
}
