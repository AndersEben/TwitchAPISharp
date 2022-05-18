﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseGetGamesData : TemplateResponseData<ResponseGetGames>
    {

    }

    public class ResponseGetGames
    {
        [JsonProperty]
        public string id { get; internal set; }
        [JsonProperty]
        public string name { get; internal set; }
        [JsonProperty]
        public string box_art_url { get; internal set; }
    }
}
