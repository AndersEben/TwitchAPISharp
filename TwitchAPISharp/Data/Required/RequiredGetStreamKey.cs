using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetStreamKey : OptionSet<RequiredGetStreamKey>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetStreamKey
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster</param>
        public RequiredGetStreamKey(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
