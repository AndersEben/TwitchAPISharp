using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubOptional
{
    public class Optional_broadcaster : SubOptions<Optional_broadcaster>
    {
        public string from_broadcaster_user_id = null;
        public string to_broadcaster_user_id = null;
    }
}
