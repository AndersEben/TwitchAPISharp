using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetCodeStatus : OptionSet<RequiredGetCodeStatus>
    {
        public List<string> code { get; internal set; }
        public int user_id { get; internal set; }

        /// <summary>
        /// RequiredGetCodeStatus
        /// </summary>
        /// <param name="code">The code to get the status of. Repeat this query parameter additional times to get the status of multiple codes. Ex: ?code=code1&code=code2 1-20 code parameters are allowed.</param>
        /// <param name="user_id">Represents a numeric Twitch user ID. The user account which is going to receive the entitlement associated with the code.</param>
        public RequiredGetCodeStatus(List<string> code, int user_id)
        {
            this.code = code;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
