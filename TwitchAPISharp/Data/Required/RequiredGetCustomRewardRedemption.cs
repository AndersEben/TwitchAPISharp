using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetCustomRewardRedemption : OptionSet<RequiredGetCustomRewardRedemption>
    {
        public string broadcaster_id { get; internal set; }
        public string reward_id { get; internal set; }

        /// <summary>
        /// RequiredGetCustomRewardRedemption
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="reward_id">When ID is not provided, this parameter returns paginated Custom Reward Redemption objects for redemptions of the Custom Reward with ID reward_id.</param>
        public RequiredGetCustomRewardRedemption(string broadcaster_id,string reward_id)
        {
            this.broadcaster_id = broadcaster_id;
            this.reward_id   = reward_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
