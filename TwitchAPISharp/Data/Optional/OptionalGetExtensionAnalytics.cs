using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{

    public class OptionalGetExtensionAnalytics : OptionSet<OptionalGetExtensionAnalytics>
    {
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response. This applies only to queries without extension_id. If an extension_id is specified, it supersedes any cursor/offset combinations. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Ending date/time for returned reports, in RFC3339 format with the hours, minutes, and seconds zeroed out and the UTC timezone: YYYY-MM-DDT00:00:00Z. The report covers the entire ending date; e.g., if 2018-05-01T00:00:00Z is specified, the report covers up to 2018-05-01T23:59:59Z.
        /// </summary>
        public string ended_at = null;
        /// <summary>
        /// Client ID value assigned to the extension when it is created. If this is specified, the returned URL points to an analytics report for just the specified extension. If this is not specified, the response includes multiple URLs (paginated), pointing to separate analytics reports for each of the authenticated user’s Extensions.
        /// </summary>
        public string extension_id = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 100. Default: 20.
        /// </summary>
        public int first = 20;
        /// <summary>
        /// Starting date/time for returned reports, in RFC3339 format with the hours, minutes, and seconds zeroed out and the UTC timezone: YYYY-MM-DDT00:00:00Z. This must be on or after January 31, 2018.
        /// </summary>
        public string started_at = null;
        /// <summary>
        /// Type of analytics report that is returned. Currently, this field has no affect on the response as there is only one report type. If additional types were added, using this field would return only the URL for the specified report. Limit: 1. Valid values: "overview_v2".
        /// </summary>
        public string type = null;

    }
}
