using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalCreateChannelStreamScheduleSegment : OptionSet<OptionalCreateChannelStreamScheduleSegment>
    {
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
    }
}
