using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostUpdateRedemptionStatus : OptionSet<PostUpdateRedemptionStatus>
    {
        public string status { get; internal set; }

        /// <summary>
        /// PostUpdateRedemptionStatus
        /// </summary>
        /// <param name="status">The new status to set redemptions to. Can be either FULFILLED or CANCELED. Updating to CANCELED will refund the user their Channel Points.</param>
        public PostUpdateRedemptionStatus(RedemptionStatus status)
        {
            this.status = status.ToString();

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
