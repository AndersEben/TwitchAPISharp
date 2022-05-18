using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetUserBlockList : OptionSet<RequiredGetUserBlockList>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetUserBlockList
        /// </summary>
        /// <param name="broadcaster_id">User ID for a Twitch user.</param>
        public RequiredGetUserBlockList(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
