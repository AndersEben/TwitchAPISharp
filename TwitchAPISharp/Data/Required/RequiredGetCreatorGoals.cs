using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetCreatorGoals : OptionSet<RequiredGetCreatorGoals>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetCreatorGoals
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster that created the goals.</param>
        public RequiredGetCreatorGoals(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
