using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostAutoModData : OptionSet<PostAutoModData>
    {
        public string msg_id { get; internal set; }
        public string msg_text { get; internal set; }
        public string user_id { get; internal set; }

        /// <summary>
        /// PostAutoModData
        /// </summary>
        /// <param name="msg_id">Developer-generated identifier for mapping messages to results.</param>
        /// <param name="msg_text">Message text.</param>
        /// <param name="user_id">User ID of the sender.</param>
        public PostAutoModData(string msg_id, string msg_text, string user_id)
        {
            this.msg_id = msg_id;
            this.msg_text = msg_text;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
