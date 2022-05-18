using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredCheckUserSubscription : OptionSet<RequiredCheckUserSubscription>
    {
        public string broadcaster_id { get; internal set; }
        public string user_id { get; internal set; }

        /// <summary>
        /// RequiredCheckUserSubscription
        /// </summary>
        /// <param name="broadcaster_id">User ID of an Affiliate or Partner broadcaster.</param>
        /// <param name="user_id">User ID of a Twitch viewer.</param>
        public RequiredCheckUserSubscription(string broadcaster_id, string user_id)
        {
            this.broadcaster_id = broadcaster_id;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
