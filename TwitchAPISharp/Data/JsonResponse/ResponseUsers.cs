﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseUsers
    {
        [JsonProperty]
        public string user_id { get; internal set; }
        [JsonProperty]
        public string user_login { get; internal set; }
        [JsonProperty]
        public string user_name { get; internal set; }
    }
}
