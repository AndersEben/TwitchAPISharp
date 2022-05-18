using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalCreateStreamMarker : OptionSet<OptionalCreateStreamMarker>
    {
        /// <summary>
        /// Description of or comments on the marker. Max length is 140 characters.
        /// </summary>
        public string description = null;
    }
}
