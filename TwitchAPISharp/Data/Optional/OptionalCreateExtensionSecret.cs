using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalCreateExtensionSecret : OptionSet<OptionalCreateExtensionSecret>
    {
        /// <summary>
        /// JWT signing activation delay for the newly created secret in seconds. Minimum: 300. Default: 300.
        /// </summary>
        public int delay = 300;

    }
}
