using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetHypeTrainEvents : OptionSet<RequiredGetHypeTrainEvents>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetHypeTrainEvents
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster. Must match the User ID in the Bearer token if User Token is used.</param>
        public RequiredGetHypeTrainEvents(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
