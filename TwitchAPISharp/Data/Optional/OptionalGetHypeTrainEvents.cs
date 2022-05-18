using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetHypeTrainEvents : OptionSet<OptionalGetHypeTrainEvents>
    {
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 1.
        /// </summary>
        public int first = 1;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results in a multi-page response. This applies only to queries without id. If an ID is specified, it supersedes any cursor/offset combinations. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string cursor = null;
    }
}
