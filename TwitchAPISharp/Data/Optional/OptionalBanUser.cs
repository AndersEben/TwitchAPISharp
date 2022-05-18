using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalBanUser : OptionSet<OptionalBanUser>
    {
        /// <summary>
        /// The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).
        /// </summary>
        public int duration = 0;
    }
}
