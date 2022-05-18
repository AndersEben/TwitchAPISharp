using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetChannelStreamSchedule : OptionSet<OptionalGetChannelStreamSchedule>
    {
        /// <summary>
        /// The ID of the stream segment to return.

        /// </summary>
        public string id = null;
        /// <summary>
        /// A timestamp in RFC3339 format to start returning stream segments from. If not specified, the current date and time is used.
        /// </summary>
        public string start_time = null;
        /// <summary>
        /// A timezone offset for the requester specified in minutes. This is recommended to ensure stream segments are returned for the correct week. For example, a timezone that is +4 hours from GMT would be “240.” If not specified, “0” is used for GMT.
        /// </summary>
        public string utc_offset = null;
        /// <summary>
        /// Maximum number of stream segments to return. Maximum: 25. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
    }
}
