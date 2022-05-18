using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetCustomRewardRedemption : OptionSet<OptionalGetCustomRewardRedemption>
    {
        /// <summary>
        /// When used, this param filters the results and only returns Custom Reward Redemption objects for the redemptions with matching ID. Maximum: 50
        /// </summary>
        public string id = null;
        /// <summary>
        /// When id is not provided, this param is required and filters the paginated Custom Reward Redemption objects for redemptions with the matching status. Can be one of UNFULFILLED, FULFILLED or CANCELED
        /// </summary>
        public string status = null;
        /// <summary>
        /// Sort order of redemptions returned when getting the paginated Custom Reward Redemption objects for a reward. One of: OLDEST, NEWEST. Default: OLDEST.
        /// </summary>
        public string sort = null;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. This applies only to queries without ID. If an ID is specified, it supersedes any cursor/offset combinations. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Number of results to be returned when getting the paginated Custom Reward Redemption objects for a reward. Limit: 50. Default: 20.
        /// </summary>
        public int first = 20;
    }
}
