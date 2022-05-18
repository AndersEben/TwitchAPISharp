using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetFollowedStreams : OptionSet<OptionalGetFollowedStreams>
    {
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 100.
        /// </summary>
        public int first = 100;
    }
}
