using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetExtensions : OptionSet<RequiredGetExtensions>
    {
        public string extension_id { get; internal set; }

        /// <summary>
        /// RequiredGetExtensions
        /// </summary>
        /// <param name="extension_id">ID of the Extension.</param>
        public RequiredGetExtensions(string extension_id)
        {
            this.extension_id = extension_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
