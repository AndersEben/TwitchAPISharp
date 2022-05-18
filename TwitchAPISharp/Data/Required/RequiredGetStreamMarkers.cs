using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetStreamMarkers : OptionSet<RequiredGetStreamMarkers>
    {
        public string user_id { get; internal set; }
        public string video_id { get; internal set; }

        /// <summary>
        /// RequiredGetStreamMarkers
        /// </summary>
        /// <param name="user_id">ID of the broadcaster from whose stream markers are returned.</param>
        /// <param name="video_id">ID of the VOD/video whose stream markers are returned.</param>
        public RequiredGetStreamMarkers(string user_id, string video_id)
        {
            this.user_id = user_id;
            this.video_id = video_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
