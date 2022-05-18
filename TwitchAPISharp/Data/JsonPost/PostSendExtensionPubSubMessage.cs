using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostSendExtensionPubSubMessage : OptionSet<PostSendExtensionPubSubMessage>
    {
        public List<string> target { get; internal set; }
        public string broadcaster_id { get; internal set; }
        public bool is_global_broadcast { get; internal set; }
        public string message { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">Array of strings for valid PubSub targets. Valid values: "broadcast", "global", "whisper-<user-id>"</param>
        /// <param name="broadcaster_id">ID of the broadcaster receiving the payload. This is not required if is_global_broadcast is set to true.</param>
        /// <param name="is_global_broadcast">Indicates if the message should be sent to all channels where your Extension is active. Default: false.</param>
        /// <param name="message">String-encoded JSON message to be sent.</param>
        public PostSendExtensionPubSubMessage(List<string> target, string broadcaster_id, string message, bool is_global_broadcast = false)
        {
            this.target = target;
            this.broadcaster_id = broadcaster_id;
            this.is_global_broadcast = is_global_broadcast;
            this.message = message;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
