using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetBroadcasterSubscriptions : OptionSet<OptionalGetBroadcasterSubscriptions>
    {
        /// <summary>
        /// Filters the list to include only the specified subscribers. To specify more than one subscriber, include this parameter for each subscriber. For example, &user_id=1234&user_id=5678. You may specify a maximum of 100 subscribers.
        /// </summary>
        public List<string> user_id = null;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results in a multi-page response. This applies only to queries without user_id. If a user_id is specified, it supersedes any cursor/offset combinations. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
    }
}
