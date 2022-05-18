using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetStreams : OptionSet<OptionalGetStreams>
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
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Returns streams broadcasting a specified game ID. You can specify up to 100 IDs.
        /// </summary>
        public string game_id = null;
        /// <summary>
        /// Stream language. You can specify up to 100 languages. A language value must be either the ISO 639-1 two-letter code for a supported stream language or “other”.
        /// </summary>
        public string language = null;
        /// <summary>
        /// Returns streams broadcast by one or more specified user IDs. You can specify up to 100 IDs.
        /// </summary>
        public string user_id = null;
        /// <summary>
        /// Returns streams broadcast by one or more specified user login names. You can specify up to 100 names.
        /// </summary>
        public string user_login = null;
    }
}
