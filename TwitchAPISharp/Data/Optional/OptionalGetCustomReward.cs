using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetCustomReward : OptionSet<OptionalGetCustomReward>
    {
        /// <summary>
        /// When used, this parameter filters the results and only returns reward objects for the Custom Rewards with matching ID. Maximum: 50
        /// </summary>
        public string id = null;
        /// <summary>
        /// When set to true, only returns custom rewards that the calling client_id can manage. Default: false.
        /// </summary>
        public bool only_manageable_rewards = false;
    }
}
