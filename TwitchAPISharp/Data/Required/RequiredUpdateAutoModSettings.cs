using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUpdateAutoModSettings : OptionSet<RequiredUpdateAutoModSettings>
    {
        public string broadcaster_id { get; internal set; }
        public string moderator_id { get; internal set; }

        /// <summary>
        /// RequiredUpdateAutoModSettings
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster whose AutoMod settings you want to update.</param>
        /// <param name="moderator_id">The ID of a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID associated with the user OAuth token.</param>
        public RequiredUpdateAutoModSettings(string broadcaster_id, string moderator_id)
        {
            this.broadcaster_id = broadcaster_id;
            this.moderator_id = moderator_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
