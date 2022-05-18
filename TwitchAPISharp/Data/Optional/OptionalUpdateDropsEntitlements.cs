using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateDropsEntitlements : OptionSet<OptionalUpdateDropsEntitlements>
    {
        /// <summary>
        /// An array of unique identifiers of the entitlements to update. Maximum: 100.
        /// </summary>
        public List<string> entitlement_ids = null;
        /// <summary>
        /// A fulfillment status. Valid values are "CLAIMED" or "FULFILLED".
        /// </summary>
        public string fulfillment_status = null;
    }
}
