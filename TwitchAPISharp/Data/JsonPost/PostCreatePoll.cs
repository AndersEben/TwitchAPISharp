using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreatePoll : OptionSet<PostCreatePoll>
    {
        public string broadcaster_id { get; internal set; }
        public string title { get; internal set; }
        public string choices { get; internal set; }
        public int duration { get; internal set; }

        /// <summary>
        /// PostCreatePoll
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster running polls. Provided broadcaster_id must match the user_id in the user OAuth token. Maximum: 1</param>
        /// <param name="title">Question displayed for the poll. Maximum: 60 characters.</param>
        /// <param name="choices">Array of the poll choices.</param>
        /// <param name="duration">Total duration for the poll (in seconds). Minimum: 15. Maximum: 1800.</param>
        public PostCreatePoll(string broadcaster_id, string title, List<PostCreatePollChoices> choices, int duration)
        {
            this.broadcaster_id = broadcaster_id;
            this.title = title;

            string choicesdata = "[";
            bool first = true;

            foreach (PostCreatePollChoices PollChoice in choices)
            {
                if (!first)
                    choicesdata += PollChoice.GetDataString(true);
                else
                {
                    choicesdata += PollChoice.GetDataString();
                    first = !first;
                }
            }

            choicesdata += "]";

            this.choices = choicesdata;
            this.duration = duration;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
