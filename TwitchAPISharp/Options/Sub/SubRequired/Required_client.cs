using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubRequired
{
    public class Required_client : SubOptions<Required_client>
    {
        public string client_id { get; internal set; }

        public Required_client(string client_id)
        {
            this.client_id = client_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
