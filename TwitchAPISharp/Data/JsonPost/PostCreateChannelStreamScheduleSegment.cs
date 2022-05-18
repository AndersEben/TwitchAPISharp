using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreateChannelStreamScheduleSegment : OptionSet<PostCreateChannelStreamScheduleSegment>
    {
        public string start_time { get; internal set; }
        public string timezone { get; internal set; }
        public bool is_recurring { get; internal set; }

        /// <summary>
        /// PostCreateChannelStreamScheduleSegment
        /// </summary>
        /// <param name="start_time">Start time for the scheduled broadcast specified in RFC3339 format.</param>
        /// <param name="timezone">The timezone of the application creating the scheduled broadcast using the IANA time zone database format.</param>
        /// <param name="is_recurring">Indicates if the scheduled broadcast is recurring weekly.</param>
        public PostCreateChannelStreamScheduleSegment(string start_time, string timezone, bool is_recurring)
        {
            this.start_time = start_time;
            this.timezone = timezone;
            this.is_recurring = is_recurring;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
