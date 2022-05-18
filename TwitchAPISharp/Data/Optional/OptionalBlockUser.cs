using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalBlockUser : OptionSet<OptionalBlockUser>
    {
        /// <summary>
        /// Valid values: "chat", "whisper".
        /// </summary>
        public string source_context = null;
        /// <summary>
        ///  Valid values: "spam", "harassment", or "other".
        /// </summary>
        public string reason = null;
    }
}
