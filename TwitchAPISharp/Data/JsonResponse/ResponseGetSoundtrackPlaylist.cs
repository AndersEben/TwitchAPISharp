using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetSoundtrackPlaylistData : TemplateResponseData<ResponseGetSoundtrackPlaylist>
    {

    }

    public class ResponseGetSoundtrackPlaylist
    {
        [JsonProperty]
        public string title { get; internal set; }
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string image_url { get; internal set; }
        [JsonProperty]
        public string description { get; internal set; }
    }
}
