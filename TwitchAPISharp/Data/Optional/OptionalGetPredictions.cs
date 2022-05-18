using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetPredictions : OptionSet<OptionalGetPredictions>
    {
        /// <summary>
        /// ID of a Prediction. Filters results to one or more specific Predictions. Not providing one or more IDs will return the full list of Predictions for the authenticated channel. Maximum: 100
        /// </summary>
        public string id = null;
        /// <summary>
        /// Cursor for forward pagination: tells the server where to start fetching the next set of results in a multi-page response. The cursor value specified here is from the pagination response field of a prior query.
        /// </summary>
        public string after = null;
        /// <summary>
        /// Maximum number of objects to return. Maximum: 20. Default: 20.
        /// </summary>
        public int first = 20;
    }
}
