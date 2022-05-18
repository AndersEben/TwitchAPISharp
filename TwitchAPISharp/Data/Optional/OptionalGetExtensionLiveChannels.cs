using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetExtensionLiveChannels : OptionSet<OptionalGetExtensionLiveChannels>
    {
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// The cursor used to fetch the next page of data.
        /// </summary>
        public string after = null;
    }
}
