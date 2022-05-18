using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetUsersFollows : OptionSet<OptionalGetUsersFollows>
    {
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// User ID. The request returns information about users who are being followed by the from_id user.
        /// </summary>
        public string from_id = null;
        /// <summary>
        /// User ID. The request returns information about users who are following the to_id user.
        /// </summary>
        public string to_id = null;
    }
}
