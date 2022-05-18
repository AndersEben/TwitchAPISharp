using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetPolls : OptionSet<RequiredGetPolls>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetPolls
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster running polls. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        public RequiredGetPolls(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
