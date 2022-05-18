using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateChannelStreamScheduleSegment : OptionSet<OptionalUpdateChannelStreamScheduleSegment>
    {
        /// <summary>
        /// Start time for the scheduled broadcast specified in RFC3339 format.
        /// </summary>
        public string start_time = null;
        /// <summary>
        /// Duration of the scheduled broadcast in minutes from the start_time. Default: 240.
        /// </summary>
        public int duration = 240;
        /// <summary>
        /// Game/Category ID for the scheduled broadcast.
        /// </summary>
        public string category_id = null;
        /// <summary>
        /// Title for the scheduled broadcast. Maximum: 140 characters.
        /// </summary>
        public string title = null;
        /// <summary>
        /// Indicated if the scheduled broadcast is canceled.
        /// </summary>
        public bool is_canceled = false;
        /// <summary>
        /// The timezone of the application creating the scheduled broadcast using the IANA time zone database format.
        /// </summary>
        public string timezone = null;

    }
}
