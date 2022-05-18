using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUpdateCustomReward : OptionSet<RequiredUpdateCustomReward>
    {
        public string broadcaster_id { get; internal set; }
        public string id { get; internal set; }

        /// <summary>
        /// RequiredUpdateCustomReward
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">ID of the Custom Reward to update. Must match a Custom Reward on the channel of the broadcaster_id.</param>
        public RequiredUpdateCustomReward(string broadcaster_id,string id)
        {
            this.broadcaster_id = broadcaster_id;
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
