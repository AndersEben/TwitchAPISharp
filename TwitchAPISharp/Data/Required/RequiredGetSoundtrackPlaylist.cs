using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetSoundtrackPlaylist : OptionSet<RequiredGetSoundtrackPlaylist>
    {
        public string id { get; internal set; }

        /// <summary>
        /// RequiredGetSoundtrackPlaylist
        /// </summary>
        /// <param name="id">The ID of the Soundtrack playlist to get.</param>
        public RequiredGetSoundtrackPlaylist(string id)
        {
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
