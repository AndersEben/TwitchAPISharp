using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseTrack
    {
        [JsonProperty]
        public List<ResponseTrackArtists> artists { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public int duration { get; internal set; }
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public ResponseTrackAlbum album { get; internal set; }
    }

    public class ResponseTrackArtists
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string creator_channel_id { get; internal set; }
    }

    public class ResponseTrackAlbum
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string image_url { get; internal set; }
    }
}
