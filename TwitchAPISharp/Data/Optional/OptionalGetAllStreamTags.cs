using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetAllStreamTags : OptionSet<OptionalGetAllStreamTags>
    {
        /// <summary>
        /// The cursor used to get the next page of results. The pagination object in the response contains the cursor’s value. The after and tag_id query parameters are mutually exclusive.
        /// </summary>
        public string after = null;
        /// <summary>
        /// An ID that identifies a specific tag to return. Include the query parameter for each tag you want returned. For example, tag_id=123&tag_id=456. You may specify a maximum of 100 IDs.
        /// </summary>
        public string tag_id = null;
        /// <summary>
        /// The maximum number of tags to return per page. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
    }
}
