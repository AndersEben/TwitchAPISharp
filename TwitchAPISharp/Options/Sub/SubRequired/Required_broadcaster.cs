using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubRequired
{
    public class Required_broadcaster : SubOptions<Required_broadcaster>
    {
        public string broadcaster_user_id { get; internal set; }

        public Required_broadcaster(string broadcaster_user_id)
        {
            this.broadcaster_user_id = broadcaster_user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
