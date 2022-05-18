using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostSetExtensionConfigurationSegment : OptionSet<PostSetExtensionConfigurationSegment>
    {
        public string extension_id { get; internal set; }
        public string segment { get; internal set; }

        /// <summary>
        /// PostSetExtensionConfigurationSegment
        /// </summary>
        /// <param name="extension_id">ID for the Extension which the configuration is for.</param>
        /// <param name="segment">Configuration type. Valid values are "global", "developer", or "broadcaster".</param>
        public PostSetExtensionConfigurationSegment(string extension_id, string segment)
        {
            this.extension_id = extension_id;
            this.segment = segment;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
