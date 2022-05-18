using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetExtensionBitsProducts : OptionSet<OptionalGetExtensionBitsProducts>
    {
        /// <summary>
        /// Whether Bits products that are disabled/expired should be included in the response. Default: false.
        /// </summary>
        public bool should_include_all = false;
    }
}
