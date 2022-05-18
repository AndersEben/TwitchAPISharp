using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredDeleteCustomReward : OptionSet<RequiredDeleteCustomReward>
    {
        public string broadcaster_id { get; internal set; }
        public int id { get; internal set; }

        /// <summary>
        /// RequiredDeleteCustomReward
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">ID of the Custom Reward to delete, must match a Custom Reward on broadcaster_id’s channel.</param>
        public RequiredDeleteCustomReward(string broadcaster_id,int id)
        {
            this.broadcaster_id = broadcaster_id;
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
