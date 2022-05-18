using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUnbanUser : OptionSet<RequiredUnbanUser>
    {
        public string broadcaster_id { get; internal set; }
        public string moderator_id { get; internal set; }
        public string user_id { get; internal set; }

        /// <summary>
        /// RequiredUnbanUser
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster whose chat room the user is banned from chatting in.</param>
        /// <param name="moderator_id">The ID of a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID associated with the user OAuth token.</param>
        /// <param name="user_id">The ID of the user to remove the ban or timeout from.</param>
        public RequiredUnbanUser(string broadcaster_id, string moderator_id, string user_id)
        {
            this.broadcaster_id = broadcaster_id;
            this.moderator_id = moderator_id;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
