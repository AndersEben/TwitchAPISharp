using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetClips : OptionSet<OptionalGetClips>
    {
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. This applies only to queries specifying broadcaster_id or game_id. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Cursor for backward pagination: tells the server where to start fetching the next set of results, in a multi-page response. This applies only to queries specifying broadcaster_id or game_id. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string before = null;
        /// <summary>
        /// Ending date/time for returned clips, in RFC3339 format. (Note that the seconds value is ignored.) If this is specified, started_at also must be specified; otherwise, the time period is ignored.
        /// </summary>
        public string ended_at = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Starting date/time for returned clips, in RFC3339 format. (The seconds value is ignored.) If this is specified, ended_at also should be specified; otherwise, the ended_at date/time will be 1 week after the started_at value.
        /// </summary>
        public string started_at = null;

    }
}
