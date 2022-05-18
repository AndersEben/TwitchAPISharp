using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetClips : OptionSet<RequiredGetClips>
    {
        /// <summary>
        /// ID of the broadcaster for whom clips are returned. The number of clips returned is determined by the first query-string parameter (default: 20). Results are ordered by view count.
        /// </summary>
        public string broadcaster_id { get; internal set; }
        /// <summary>
        /// ID of the game for which clips are returned. The number of clips returned is determined by the first query-string parameter (default: 20). Results are ordered by view count.
        /// </summary>
        public string game_id { get; internal set; }
        /// <summary>
        /// ID of the clip being queried. Limit: 100.
        /// </summary>
        public string id { get; internal set; }

    }
}
