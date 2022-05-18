using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredReplaceStreamTags : OptionSet<RequiredReplaceStreamTags>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredReplaceStreamTags
        /// </summary>
        /// <param name="broadcaster_id">The user ID of the channel to apply the tags to.</param>
        public RequiredReplaceStreamTags(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
