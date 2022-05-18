using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseDeleteVideosData 
    {
        [JsonProperty]
        public List<string> data { get; internal set; }
    }
}
