using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostSendExtensionChatMessage : OptionSet<PostSendExtensionChatMessage>
    {
        public string text { get; internal set; }
        public string extension_id { get; internal set; }
        public string extension_version { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">Message for Twitch chat. Maximum: 280 characters.</param>
        /// <param name="extension_id">Client ID associated with the Extension.</param>
        /// <param name="extension_version">Version of the Extension sending this message.</param>
        public PostSendExtensionChatMessage(string text, string extension_id, string extension_version)
        {
            this.text = text;
            this.extension_id = extension_id;
            this.extension_version = extension_version;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
