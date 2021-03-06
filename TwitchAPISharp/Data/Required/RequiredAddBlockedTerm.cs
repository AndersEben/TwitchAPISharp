using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredAddBlockedTerm : OptionSet<RequiredAddBlockedTerm>
    {
        public string broadcaster_id { get; internal set; }
        public string moderator_id { get; internal set; }

        /// <summary>
        /// RequiredAddBlockedTerm
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster that owns the list of blocked terms.</param>
        /// <param name="moderator_id">The ID of a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID associated with the user OAuth token.</param>
        public RequiredAddBlockedTerm(string broadcaster_id, string moderator_id)
        {
            this.broadcaster_id = broadcaster_id;
            this.moderator_id = moderator_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
