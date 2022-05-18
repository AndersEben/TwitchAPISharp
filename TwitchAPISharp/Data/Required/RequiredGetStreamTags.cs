using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetStreamTags : OptionSet<RequiredGetStreamTags>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetStreamTags
        /// </summary>
        /// <param name="broadcaster_id">The user ID of the channel to get the tags from.</param>
        public RequiredGetStreamTags(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
