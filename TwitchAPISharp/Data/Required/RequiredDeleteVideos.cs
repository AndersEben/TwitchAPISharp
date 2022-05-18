using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredDeleteVideos : OptionSet<RequiredDeleteVideos>
    {
        public List<string> id { get; internal set; }

        /// <summary>
        /// RequiredDeleteVideos
        /// </summary>
        /// <param name="id">ID of the video(s) to be deleted. Limit: 5.</param>
        public RequiredDeleteVideos(List<string> id)
        {
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
