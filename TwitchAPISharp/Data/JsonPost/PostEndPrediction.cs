using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostEndPrediction : OptionSet<PostEndPrediction>
    {
        public string broadcaster_id { get; internal set; }
        public string id { get; internal set; }
        public string status { get; internal set; }

        /// <summary>
        /// PostEndPrediction
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster running prediction events. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">ID of the Prediction.</param>
        /// <param name="status">The Prediction status to be set. Valid values: RESOLVED: A winning outcome has been chosen and the Channel Points have been distributed to the users who predicted the correct outcome. CANCELED: The Prediction has been canceled and the Channel Points have been refunded to participants. LOCKED: The Prediction has been locked and viewers can no longer make predictions.</param>
        public PostEndPrediction(string broadcaster_id,string id, EndPredictionStatus status)
        {
            this.broadcaster_id = broadcaster_id;
            this.id = id;
            this.status = status.ToString();

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
