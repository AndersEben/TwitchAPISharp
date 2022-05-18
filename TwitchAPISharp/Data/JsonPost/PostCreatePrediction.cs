using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreatePrediction : OptionSet<PostCreatePrediction>
    {
        public string broadcaster_id { get; internal set; }
        public string title { get; internal set; }
        public string outcomes { get; internal set; }
        public int prediction_window { get; internal set; }

        /// <summary>
        /// PostCreatePrediction
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster running Predictions. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="title">Title for the Prediction. Maximum: 45 characters.</param>
        /// <param name="outcomes">Array of outcome objects with titles for the Prediction. Array size must be 2. The first outcome object is the “blue” outcome and the second outcome object is the “pink” outcome when viewing the Prediction on Twitch.</param>
        /// <param name="prediction_window">Total duration for the Prediction (in seconds). Minimum: 1. Maximum: 1800.</param>
        public PostCreatePrediction(string broadcaster_id, string title, List<PostPredictionOutcomes> outcomes, int prediction_window)
        {
            this.broadcaster_id = broadcaster_id;
            this.title = title;

            string outcomesdata = "[";
            bool first = true;

            foreach (PostPredictionOutcomes PredOutcomes in outcomes)
            {
                if (!first)
                    outcomesdata += PredOutcomes.GetDataString(true);
                else
                {
                    outcomesdata += PredOutcomes.GetDataString();
                    first = !first;
                }

            }

            outcomesdata += "]";

            this.outcomes = outcomesdata;
            this.prediction_window = prediction_window;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
