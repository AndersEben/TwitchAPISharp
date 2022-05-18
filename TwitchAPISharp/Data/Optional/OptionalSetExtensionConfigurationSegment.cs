using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalSetExtensionConfigurationSegment : OptionSet<OptionalSetExtensionConfigurationSegment>
    {
        /// <summary>
        /// User ID of the broadcaster. Required if the segment type is "developer" or "broadcaster".
        /// </summary>
        public string broadcaster_id = null;
        /// <summary>
        /// Configuration in a string-encoded format.
        /// </summary>
        public string content = null;
        /// <summary>
        /// Configuration version with the segment type.
        /// </summary>
        public string version = null;
    }
}
