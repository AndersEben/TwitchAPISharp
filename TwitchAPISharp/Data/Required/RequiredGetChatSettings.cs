using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetChatSettings : OptionSet<RequiredGetChatSettings>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetChatSettings
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster whose chat settings you want to get.</param>
        public RequiredGetChatSettings(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
