using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalEndPrediction : OptionSet<OptionalEndPrediction>
    {
        /// <summary>
        /// ID of the winning outcome for the Prediction. This parameter is required if status is being set to RESOLVED.
        /// </summary>
        public string winning_outcome_id = null;
    }
}
