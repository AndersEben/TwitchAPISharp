using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostBanUserData : OptionSet<PostBanUserData>
    {
        public string reason { get; internal set; }
        public string user_id { get; internal set; }

        /// <summary>
        /// PostBanUserData
        /// </summary>
        /// <param name="reason">The reason the user is being banned or put in a timeout. The text is user defined and limited to a maximum of 500 characters.</param>
        /// <param name="user_id">The ID of the user to ban or put in a timeout.</param>
        public PostBanUserData(string reason, string user_id)
        {
            this.reason = reason;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
