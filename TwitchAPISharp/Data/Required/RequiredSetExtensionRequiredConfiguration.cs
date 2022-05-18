using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredSetExtensionRequiredConfiguration : OptionSet<RequiredSetExtensionRequiredConfiguration>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredSetExtensionRequiredConfiguration
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who has activated the specified Extension on their channel.</param>
        public RequiredSetExtensionRequiredConfiguration(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
