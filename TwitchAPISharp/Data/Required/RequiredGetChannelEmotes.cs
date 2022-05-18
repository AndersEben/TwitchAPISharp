using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetChannelEmotes : OptionSet<RequiredGetChannelEmotes>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetChannelEmotes
        /// </summary>
        /// <param name="broadcaster_id">An ID that identifies the broadcaster to get the emotes from.</param>
        public RequiredGetChannelEmotes(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
