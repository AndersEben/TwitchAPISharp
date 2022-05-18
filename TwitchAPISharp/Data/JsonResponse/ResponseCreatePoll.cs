using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseCreatePollData : TemplateResponseData<ResponseCreatePoll>
    {

    }

    public class ResponseCreatePoll
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
        public List<ResponseChoices> choices { get; internal set; }
        [JsonProperty]
        public bool bits_voting_enabled { get; internal set; }
        [JsonProperty]
        public int bits_per_vote { get; internal set; }
        [JsonProperty]
        public bool channel_points_voting_enabled { get; internal set; }
        [JsonProperty]
        public int channel_points_per_vote { get; internal set; }
        [JsonProperty]
        public string status { get; internal set; }
        [JsonProperty]
        public int duration { get; internal set; }
        [JsonProperty]
        public string started_at { get; internal set; }
        [JsonProperty]
        public string ended_at { get; internal set; }
    }
}
