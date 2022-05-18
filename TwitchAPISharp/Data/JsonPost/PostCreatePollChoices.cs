using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreatePollChoices : OptionSet<PostCreatePollChoices>
    {
        public string title { get; internal set; }

        /// <summary>
        /// PostCreatePollChoices
        /// </summary>
        /// <param name="title">Text displayed for the choice. Maximum: 25 characters.</param>
        public PostCreatePollChoices(string title)
        {
            this.title = title;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

    }
}
