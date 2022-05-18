using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetChatSettings : OptionSet<OptionalGetChatSettings>
    {
        /// <summary>
        /// Required only to access the non_moderator_chat_delay or non_moderator_chat_delay_duration settings.
        /// </summary>
        public string moderator_id = null;

    }
}
