using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetChannelInformation : OptionSet<RequiredGetChannelInformation>
    {
        public List<string> broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetChannelInformation
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster whose channel you want to get. To specify more than one ID, include this parameter for each broadcaster you want to get. For example, broadcaster_id=1234&broadcaster_id=5678. You may specify a maximum of 100 IDs.</param>
        public RequiredGetChannelInformation(List<string> broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
