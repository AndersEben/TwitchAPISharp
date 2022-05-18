using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetExtensionTransactions : OptionSet<OptionalGetExtensionTransactions>
    {
        /// <summary>
        /// Transaction IDs to look up. Can include multiple to fetch multiple transactions in a single request.
        /// </summary>
        public string id = null;
        /// <summary>
        /// The cursor used to fetch the next page of data. This only applies to queries without ID. If an ID is specified, it supersedes the cursor.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;

    }
}
