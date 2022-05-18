using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalReplaceStreamTags : OptionSet<OptionalReplaceStreamTags>
    {
        /// <summary>
        /// A list of IDs that identify the tags to apply to the channel. You may specify a maximum of five tags. To remove all tags from the channel, set tag_ids to an empty array.
        /// </summary>
        public List<string> tag_ids = null;
    }
}
