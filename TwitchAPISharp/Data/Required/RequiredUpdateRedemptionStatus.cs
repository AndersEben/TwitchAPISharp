using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUpdateRedemptionStatus : OptionSet<RequiredUpdateRedemptionStatus>
    {
        public string id { get; internal set; }
        public string broadcaster_id { get; internal set; }
        public string reward_id { get; internal set; }

        /// <summary>
        /// RequiredUpdateRedemptionStatus
        /// </summary>
        /// <param name="id">ID of the Custom Reward Redemption to update, must match a Custom Reward Redemption on broadcaster_id’s channel. Maximum: 50.</param>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="reward_id">ID of the Custom Reward the redemptions to be updated are for.</param>
        public RequiredUpdateRedemptionStatus(string id, string broadcaster_id,string reward_id)
        {
            this.id = id;
            this.broadcaster_id = broadcaster_id;
            this.reward_id = reward_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
