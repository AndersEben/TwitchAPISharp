using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredSendExtensionChatMessage : OptionSet<RequiredSendExtensionChatMessage>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredSendExtensionChatMessage
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster whose channel has the Extension activated.</param>
        public RequiredSendExtensionChatMessage(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
