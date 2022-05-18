using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub.SubRequired
{
    public class Required_organization : SubOptions<Required_organization>
    {
        public string organization_id { get; internal set; }

        public Required_organization(string organization_id)
        {
            this.organization_id = organization_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
