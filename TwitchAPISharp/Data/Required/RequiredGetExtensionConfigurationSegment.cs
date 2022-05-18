using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetExtensionConfigurationSegment : OptionSet<RequiredGetExtensionConfigurationSegment>
    {
        public string broadcaster_id { get; internal set; }
        public string extension_id { get; internal set; }
        public string segment { get; internal set; }

        /// <summary>
        /// RequiredGetExtensionConfigurationSegment
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster for the configuration returned. This parameter is required if you set the segment parameter to broadcaster or developer. Do not specify this parameter if you set segment to global.</param>
        /// <param name="extension_id">The ID of the extension that contains the configuration segment you want to get.</param>
        /// <param name="segment">The type of configuration segment to get. Valid values are: broadcaster / developer / global . You may specify one or more segments.To specify multiple segments, include the segment parameter for each segment to get. For example, segment= broadcaster & segment = developer.</param>
        public RequiredGetExtensionConfigurationSegment(string broadcaster_id, string extension_id, string segment)
        {
            this.broadcaster_id = broadcaster_id;
            this.extension_id = extension_id;
            this.segment = segment;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
