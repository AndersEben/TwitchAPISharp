using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredModifyChannelInformation : OptionSet<RequiredModifyChannelInformation>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredModifyChannelInformation
        /// </summary>
        /// <param name="broadcaster_id">ID of the channel to be updated</param>
        public RequiredModifyChannelInformation(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
