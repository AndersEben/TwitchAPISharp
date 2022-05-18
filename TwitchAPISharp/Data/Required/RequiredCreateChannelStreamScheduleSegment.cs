using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredCreateChannelStreamScheduleSegment : OptionSet<RequiredCreateChannelStreamScheduleSegment>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredCreateChannelStreamScheduleSegment
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who owns the channel streaming schedule. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        public RequiredCreateChannelStreamScheduleSegment(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
