using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostSetExtensionRequiredConfiguration : OptionSet<PostSetExtensionRequiredConfiguration>
    {
        public string extension_id { get; internal set; }
        public string extension_version { get; internal set; }
        public string configuration_version { get; internal set; }

        /// <summary>
        /// PostSetExtensionRequiredConfiguration
        /// </summary>
        /// <param name="extension_id">ID for the Extension to activate.</param>
        /// <param name="extension_version">The version fo the Extension to release.</param>
        /// <param name="configuration_version">The version of the configuration to use with the Extension.</param>
        public PostSetExtensionRequiredConfiguration(string extension_id, string extension_version,string configuration_version)
        {
            this.extension_id = extension_id;
            this.extension_version = extension_version;
            this.configuration_version = configuration_version;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
