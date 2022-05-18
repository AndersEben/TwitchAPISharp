using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetBlockedTerms : OptionSet<OptionalGetBlockedTerms>
    {
        /// <summary>
        /// The cursor used to get the next page of results. The Pagination object in the response contains the cursor’s value.
        /// </summary>
        public string after = null;
        /// <summary>
        /// The maximum number of blocked terms to return per page in the response. The minimum page size is 1 blocked term per page and the maximum is 100. The default is 20.
        /// </summary>
        public int first = 20;
    }
}
