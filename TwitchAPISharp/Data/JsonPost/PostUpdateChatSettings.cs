using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostUpdateChatSettings : OptionSet<PostUpdateChatSettings>
    {
        public bool emote_mode { get; internal set; }
        public bool follower_mode { get; internal set; }
        public int follower_mode_duration { get; internal set; }
        public bool non_moderator_chat_delay { get; internal set; }
        public int non_moderator_chat_delay_duration { get; internal set; }
        public bool slow_mode { get; internal set; }
        public int slow_mode_wait_time { get; internal set; }
        public bool subscriber_mode { get; internal set; }
        public bool unique_chat_mode { get; internal set; }

        /// <summary>
        /// PostUpdateChatSettings
        /// </summary>
        /// <param name="emote_mode">A Boolean value that determines whether chat messages must contain only emotes. Set to true, if only messages that are 100% emotes are allowed; otherwise, false. Default is false.</param>
        /// <param name="follower_mode">A Boolean value that determines whether the broadcaster restricts the chat room to followers only, based on how long they’ve followed. Set to true, if the broadcaster restricts the chat room to followers only; otherwise, false. Default is true.</param>
        /// <param name="follower_mode_duration">The length of time, in minutes, that the followers must have followed the broadcaster to participate in the chat room (see follower_mode).</param>
        /// <param name="non_moderator_chat_delay">A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message. Set to true, if the broadcaster applies a delay; otherwise, false. Default is false.</param>
        /// <param name="non_moderator_chat_delay_duration">The amount of time, in seconds, that messages are delayed from appearing in chat. Possible values are: 2 — 2 second delay(recommended) / 4 — 4 second delay / 6 — 6 second delay</param>
        /// <param name="slow_mode">A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to true, if the broadcaster applies a wait period messages; otherwise, false. Default is false.</param>
        /// <param name="slow_mode_wait_time">The amount of time, in seconds, that users need to wait between sending messages (see slow_mode).</param>
        /// <param name="subscriber_mode">A Boolean value that determines whether only users that subscribe to the broadcaster’s channel can talk in the chat room. Set to true, if the broadcaster restricts the chat room to subscribers only; otherwise, false. Default is false.</param>
        /// <param name="unique_chat_mode">A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room. Set to true, if the broadcaster requires unique messages only; otherwise, false. Default is false.</param>
        public PostUpdateChatSettings(
            bool emote_mode = false, bool follower_mode = false, int follower_mode_duration = 0, 
            bool non_moderator_chat_delay = false, int non_moderator_chat_delay_duration = 2, 
            bool slow_mode = false, int slow_mode_wait_time = 30, bool subscriber_mode = false, 
            bool unique_chat_mode = false)
        {

            this.emote_mode = emote_mode;
            this.follower_mode = follower_mode;
            this.follower_mode_duration = follower_mode_duration;
            this.non_moderator_chat_delay = non_moderator_chat_delay;
            this.non_moderator_chat_delay_duration = non_moderator_chat_delay_duration;
            this.slow_mode = slow_mode;
            this.slow_mode_wait_time = slow_mode_wait_time;
            this.subscriber_mode = subscriber_mode;
            this.unique_chat_mode = unique_chat_mode;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
