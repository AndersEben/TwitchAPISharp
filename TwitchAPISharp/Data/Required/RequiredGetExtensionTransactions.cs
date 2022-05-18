using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetExtensionTransactions : OptionSet<RequiredGetExtensionTransactions>
    {
        public string extension_id { get; private set; }

        /// <summary>
        /// RequiredGetExtensionTransactions
        /// </summary>
        /// <param name="Extension_id">ID of the Extension to list transactions for. Maximum: 1</param>
        public RequiredGetExtensionTransactions(string Extension_id)
        {
            this.extension_id = Extension_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
