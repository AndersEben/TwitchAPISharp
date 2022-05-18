using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostAddBlockedTerm : OptionSet<PostAddBlockedTerm>
    {
        public string text { get; internal set; }

        /// <summary>
        /// PostAddBlockedTerm
        /// </summary>
        /// <param name="text">The word or phrase to block from being used in the broadcaster’s chat room. The term must contain a minimum of 2 characters and may contain up to a maximum of 500 characters. Terms can use a wildcard character(*). The wildcard character must appear at the beginning or end of a word, or set of characters.For example, * foo or foo*.</param>
        public PostAddBlockedTerm(string text)
        {
            this.text = text;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
