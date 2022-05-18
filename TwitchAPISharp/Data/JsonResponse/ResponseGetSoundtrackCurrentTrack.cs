using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetSoundtrackCurrentTrackData : TemplateResponseData<ResponseGetSoundtrackCurrentTrack>
    {

    }

    public class ResponseGetSoundtrackCurrentTrack
    {
        [JsonProperty]
        public ResponseTrack track { get; internal set; }
        [JsonProperty]
        public ResponseSource source { get; internal set; }
    }
}
