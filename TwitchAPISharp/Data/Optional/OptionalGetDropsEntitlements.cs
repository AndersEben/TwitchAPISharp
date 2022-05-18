using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetDropsEntitlements : OptionSet<OptionalGetDropsEntitlements>
    {
        /// <summary>
        /// Unique identifier of the entitlement.
        /// </summary>
        public string id = null;
        /// <summary>
        /// A Twitch user ID.
        /// </summary>
        public string user_id = null;
        /// <summary>
        /// A Twitch game ID.
        /// </summary>
        public string game_iod = null;
        /// <summary>
        /// An optional fulfillment status used to filter entitlements. Valid values are "CLAIMED" or "FULFILLED".
        /// </summary>
        public string fulfillment_status = null;
        /// <summary>
        /// The cursor used to fetch the next page of data.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of entitlements to return. Default: 20 Max: 1000
        /// </summary>
        public int first = 20;

    }
}
