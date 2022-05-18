using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostPredictionOutcomes : OptionSet<PostPredictionOutcomes>
    {
        public string title { get; internal set; }

        /// <summary>
        /// PostPredictionOutcomes
        /// </summary>
        /// <param name="title">Text displayed for the outcome choice. Maximum: 25 characters.</param>
        public PostPredictionOutcomes(string title)
        {
            this.title = title;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
