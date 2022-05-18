using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetModerators : OptionSet<OptionalGetModerators>
    {
        /// <summary>
        /// Filters the results and only returns a status object for users who are moderators in this channel and have a matching user_id. Format: Repeated Query Parameter, eg. /moderation/moderators? broadcaster_id = 1 & user_id = 2 & user_id = 3 Maximum: 100
        /// </summary>
        public List<string> user_id = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results in a multi-page response. This applies only to queries without user_id. If a user_id is specified, it supersedes any cursor/offset combinations. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
    }
}
