using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateExtensionBitsProduct : OptionSet<OptionalUpdateExtensionBitsProduct>
    {
        /// <summary>
        /// Set to true if the product is in development and not yet released for public use. Default: false.
        /// </summary>
        public bool in_development = false;
        /// <summary>
        /// Expiration time for the product in RFC3339 format. If not provided, the Bits product will not have an expiration date. Setting an expiration in the past will disable the product.
        /// </summary>
        public string expiration = null;
        /// <summary>
        /// Indicates if Bits product purchase events are broadcast to all instances of an Extension on a channel via the “onTransactionComplete” helper callback. Default: false.
        /// </summary>
        public bool is_broadcast = false;
    }
}
