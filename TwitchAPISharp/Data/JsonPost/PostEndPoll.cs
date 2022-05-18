using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostEndPoll : OptionSet<PostEndPoll>
    {
        public string broadcaster_id { get; internal set; }
        public string id { get; internal set; }
        public string status { get; internal set; }

        /// <summary>
        /// PostEndPoll
        /// </summary>
        /// <param name="broadcaster_id">The broadcaster running polls. Provided broadcaster_id must match the user_id in the user OAuth token.</param>
        /// <param name="id">ID of the poll.</param>
        /// <param name="status">The poll status to be set. Valid values: TERMINATED: End the poll manually, but allow it to be viewed publicly. ARCHIVED: End the poll manually and do not allow it to be viewed publicly.</param>
        public PostEndPoll(string broadcaster_id, string id ,EndPollStatus status)
        {
            this.broadcaster_id = broadcaster_id;
            this.id = id;
            this.status = status.ToString();

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
