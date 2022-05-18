using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostStartCommercial : OptionSet<PostStartCommercial>
    {
        public string broadcaster_id { get; internal set; }
        public int length { get; internal set; }

        /// <summary>
        /// PostStartCommercial
        /// </summary>
        /// <param name="broadcaster_id">ID of the channel requesting a commercial. Minimum: 1 Maximum: 1</param>
        /// <param name="lenght">Desired length of the commercial in seconds. Valid options are 30, 60, 90, 120, 150, 180.</param>
        public PostStartCommercial(string broadcaster_id, CommercialLength lenght)
        {
            this.broadcaster_id = broadcaster_id;
            this.length = lenght.length;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
