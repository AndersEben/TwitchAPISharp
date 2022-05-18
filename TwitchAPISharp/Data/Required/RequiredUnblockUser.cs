using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredUnblockUser : OptionSet<RequiredUnblockUser>
    {
        public string target_user_id { get; internal set; }

        /// <summary>
        /// RequiredUnblockUser
        /// </summary>
        /// <param name="target_user_id">User ID of the user to be unblocked.</param>
        public RequiredUnblockUser(string target_user_id)
        {
            this.target_user_id = target_user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
