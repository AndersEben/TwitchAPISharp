using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUpdateChannelStreamSchedule : OptionSet<RequiredUpdateChannelStreamSchedule>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredUpdateChannelStreamSchedule
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who owns the channel streaming schedule. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        public RequiredUpdateChannelStreamSchedule(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
