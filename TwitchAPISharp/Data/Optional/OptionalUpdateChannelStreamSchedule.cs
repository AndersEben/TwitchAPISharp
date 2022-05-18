using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateChannelStreamSchedule : OptionSet<OptionalUpdateChannelStreamSchedule>
    {
        /// <summary>
        /// Indicates if Vacation Mode is enabled. Set to true to add a vacation or false to remove vacation from the channel streaming schedule.
        /// </summary>
        public bool is_vacation_enabled = false;
        /// <summary>
        /// Start time for vacation specified in RFC3339 format. Required if is_vacation_enabled is set to true.
        /// </summary>
        public string vacation_start_time = null;
        /// <summary>
        /// End time for vacation specified in RFC3339 format. Required if is_vacation_enabled is set to true.
        /// </summary>
        public string vacation_end_time = null;
        /// <summary>
        /// The timezone for when the vacation is being scheduled using the IANA time zone database format. Required if is_vacation_enabled is set to true.
        /// </summary>
        public string timezone = null;
    }
}
