using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetUserActiveExtensions : OptionSet<OptionalGetUserActiveExtensions>
    {
        /// <summary>
        /// ID of the user whose installed extensions will be returned. Limit: 1.
        /// </summary>
        public string user_id = null;
    }
}
