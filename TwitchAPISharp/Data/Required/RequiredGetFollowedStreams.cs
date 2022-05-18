using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetFollowedStreams : OptionSet<RequiredGetFollowedStreams>
    {
        public string user_id { get; internal set; }

        /// <summary>
        /// RequiredGetFollowedStreams
        /// </summary>
        /// <param name="user_id">Results will only include active streams from the channels that this Twitch user follows. user_id must match the User ID in the bearer token.</param>
        public RequiredGetFollowedStreams(string user_id)
        {
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
