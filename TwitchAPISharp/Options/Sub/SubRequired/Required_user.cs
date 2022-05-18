using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubRequired
{
    public class Required_user : SubOptions<Required_user>
    {
        public string user_id { get; internal set; }

        public Required_user(string user_id)
        {
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
