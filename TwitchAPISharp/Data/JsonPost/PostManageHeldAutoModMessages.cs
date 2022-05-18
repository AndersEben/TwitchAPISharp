using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostManageHeldAutoModMessages : OptionSet<PostManageHeldAutoModMessages>
    {
        public string user_id { get; internal set; }
        public string msg_id { get; internal set; }
        public string action { get; internal set; }

        /// <summary>
        /// PostManageHeldAutoModMessages
        /// </summary>
        /// <param name="user_id">The moderator who is approving or rejecting the held message. Must match the user_id in the user OAuth token.</param>
        /// <param name="msg_id">ID of the message to be allowed or denied. These message IDs are retrieved from PubSub as mentioned above. Only one message ID can be provided.</param>
        /// <param name="action">The action to take for the message. Must be "ALLOW" or "DENY".</param>
        public PostManageHeldAutoModMessages(string user_id, string msg_id, AutoModMessagesAction action)
        {
            this.user_id = user_id;
            this.msg_id = msg_id;
            this.action = action.ToString();

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }

    public class AutoModMessagesAction
    {
        public static readonly AutoModMessagesAction allow = new AutoModMessagesAction("ALLOW");
        public static readonly AutoModMessagesAction deny = new AutoModMessagesAction("DENY");

        public string action { get; private set; }

        private AutoModMessagesAction(string amount)
        {
            this.action = action;
        }
        public override string ToString()
        {
            return action;
        }
    }
}
