using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredDeleteChannelStreamScheduleSegment : OptionSet<RequiredDeleteChannelStreamScheduleSegment>
    {
        public string broadcaster_id { get; internal set; }
        public string id { get; internal set; }

        /// <summary>
        /// RequiredDeleteChannelStreamScheduleSegment
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who owns the channel streaming schedule. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">The ID of the streaming segment to delete.</param>
        public RequiredDeleteChannelStreamScheduleSegment(string broadcaster_id, string id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
