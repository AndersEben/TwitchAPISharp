using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreateStreamMarker : OptionSet<PostCreateStreamMarker>
    {
        public string user_id { get; internal set; }

        /// <summary>
        /// PostCreateStreamMarker
        /// </summary>
        /// <param name="user_id">ID of the broadcaster in whose live stream the marker is created.</param>
        public PostCreateStreamMarker(string user_id)
        {
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
