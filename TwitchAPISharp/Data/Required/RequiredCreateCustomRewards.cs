using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredCreateCustomRewards : OptionSet<RequiredCreateCustomRewards>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredCreateCustomRewards
        /// </summary>
        /// <param name="broadcaster_id">Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        public RequiredCreateCustomRewards(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
