using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonResponse
{
    public class ResponseViews
    {
        [JsonProperty]
        public ResponseViewsMobile mobile { get; internal set; }
        [JsonProperty]
        public ResponseViewsPanel panel { get; internal set; }
        [JsonProperty]
        public ResponseViewsVideoOverlay video_overlay { get; internal set; }
        [JsonProperty]
        public ResponseViewsComponent component { get; internal set; }
    }

    public class ResponseViewsMobile
    {

        [JsonProperty]
        public string viewer_url { get; internal set; }
    }

    public class ResponseViewsPanel
    {

        [JsonProperty]
        public string viewer_url { get; internal set; }
        [JsonProperty]
        public int height { get; internal set; }
        [JsonProperty]
        public bool can_link_external_content { get; internal set; }
    }
    public class ResponseViewsVideoOverlay
    {

        [JsonProperty]
        public string viewer_url { get; internal set; }
        [JsonProperty]
        public bool can_link_external_content { get; internal set; }
    }
    public class ResponseViewsComponent
    {

        [JsonProperty]
        public string viewer_url { get; internal set; }
        [JsonProperty]
        public int aspect_width { get; internal set; }
        [JsonProperty]
        public int aspect_height { get; internal set; }
        [JsonProperty]
        public int aspect_ratio_x { get; internal set; }
        [JsonProperty]
        public int aspect_ratio_y { get; internal set; }
        [JsonProperty]
        public bool autoscale { get; internal set; }
        [JsonProperty]
        public int scale_pixels { get; internal set; }
        [JsonProperty]
        public int target_height { get; internal set; }
        [JsonProperty]
        public int size { get; internal set; }
        [JsonProperty]
        public bool zoom { get; internal set; }
        [JsonProperty]
        public int zoom_pixels { get; internal set; }
        [JsonProperty]
        public bool can_link_external_content { get; internal set; }
    }
}
