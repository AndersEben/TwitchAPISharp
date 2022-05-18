using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetModerators : OptionSet<RequiredGetModerators>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetModerators
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the auth token. Maximum: 1</param>
        public RequiredGetModerators(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
