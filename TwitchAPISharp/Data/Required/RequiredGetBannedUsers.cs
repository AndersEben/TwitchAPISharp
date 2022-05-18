using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetBannedUsers : OptionSet<RequiredGetBannedUsers>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetBannedUsers
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the OAuth token</param>
        public RequiredGetBannedUsers(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
