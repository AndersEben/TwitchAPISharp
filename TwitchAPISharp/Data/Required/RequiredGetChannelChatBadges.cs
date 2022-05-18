using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetChannelChatBadges : OptionSet<RequiredGetChannelChatBadges>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetChannelChatBadges
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster whose chat badges are being requested. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        public RequiredGetChannelChatBadges(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
