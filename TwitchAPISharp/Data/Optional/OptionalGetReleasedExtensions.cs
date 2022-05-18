using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetReleasedExtensions : OptionSet<OptionalGetReleasedExtensions>
    {
        /// <summary>
        /// The specific version of the Extension to return. If not provided, the current version is returned.
        /// </summary>
        public string extension_version = null;

    }
}
