using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetBitsLeaderboard : OptionSet<OptionalGetBitsLeaderboard>
    {
        /// <summary>
        /// Number of results to be returned. Maximum: 100. Default: 10.
        /// </summary>
        public int count = 10;
        /// <summary>
        /// Time period over which data is aggregated (PST time zone). This parameter interacts with started_at. Valid values follow. Default: "all".
        /// </summary>
        public string period = null;
        /// <summary>
        /// Timestamp for the period over which the returned data is aggregated. Must be in RFC 3339 format. If this is not provided, data is aggregated over the current period; e.g., the current day/week/month/year. This value is ignored if period is "all".
        /// </summary>
        public string started_at = null;
        /// <summary>
        /// ID of the user whose results are returned; i.e., the person who paid for the Bits.
        /// </summary>
        public string user_id = null;

    }
}
