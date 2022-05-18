using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredChannelEditors : OptionSet<RequiredChannelEditors>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredChannelEditors
        /// </summary>
        /// <param name="broadcaster_id">Broadcaster’s user ID associated with the channel.</param>
        public RequiredChannelEditors(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
