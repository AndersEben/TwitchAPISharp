using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetBroadcasterSubscriptions : OptionSet<RequiredGetBroadcasterSubscriptions>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetBroadcasterSubscriptions
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster. Must match the User ID in the Bearer token.</param>
        public RequiredGetBroadcasterSubscriptions(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
