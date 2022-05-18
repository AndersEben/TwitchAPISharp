using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetSoundtrackCurrentTrack : OptionSet<RequiredGetSoundtrackCurrentTrack>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetSoundtrackCurrentTrack
        /// </summary>
        /// <param name="broadcaster_id">The ID of the broadcaster that’s playing a Soundtrack track.</param>
        public RequiredGetSoundtrackCurrentTrack(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
