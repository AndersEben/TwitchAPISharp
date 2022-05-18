using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUpdateChannelStreamScheduleSegment : OptionSet<RequiredUpdateChannelStreamScheduleSegment>
    {
        public string broadcaster_id { get; internal set; }
        public string id { get; internal set; }

        /// <summary>
        /// RequiredUpdateChannelStreamScheduleSegment
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who owns the channel streaming schedule. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">The ID of the streaming segment to update.</param>
        public RequiredUpdateChannelStreamScheduleSegment(string broadcaster_id, string id)
        {
            this.broadcaster_id = broadcaster_id;
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
