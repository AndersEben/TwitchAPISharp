using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredCreateClip : OptionSet<RequiredCreateClip>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredCreateClip
        /// </summary>
        /// <param name="broadcaster_id">ID of the stream from which the clip will be made.</param>
        public RequiredCreateClip(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
