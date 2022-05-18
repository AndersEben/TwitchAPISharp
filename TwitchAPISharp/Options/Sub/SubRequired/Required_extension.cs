using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubRequired
{
    public class Required_extension : SubOptions<Required_extension>
    {
        public string extension_client_id { get; internal set; }

        public Required_extension(string extension_client_id)
        {
            this.extension_client_id = extension_client_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
