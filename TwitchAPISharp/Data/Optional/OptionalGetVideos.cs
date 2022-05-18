using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetVideos : OptionSet<OptionalGetVideos>
    {
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Cursor for backward pagination: tells the server where to start fetching the next set of results, in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string before = null;
        /// <summary>
        /// Number of values to be returned when getting videos by user or game ID. Limit: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Language of the video being queried. Limit: 1. A language value must be either the ISO 639-1 two-letter code for a supported stream language or “other”.
        /// </summary>
        public string language = null;
        /// <summary>
        /// Period during which the video was created. Valid values: "all", "day", "week", "month". Default: "all".
        /// </summary>
        public string period = null;
        /// <summary>
        /// Sort order of the videos. Valid values: "time", "trending", "views". Default: "time".
        /// </summary>
        public string sort = null;
        /// <summary>
        /// Type of video. Valid values: "all", "upload", "archive", "highlight". Default: "all".
        /// </summary>
        public string type = null;
    }
}
