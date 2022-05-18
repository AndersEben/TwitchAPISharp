using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetVideosID : OptionSet<RequiredGetVideosID>
    {
        public List<string> id { get; internal set; }

        /// <summary>
        /// RequiredGetVideosID
        /// </summary>
        /// <param name="id">ID of the video being queried. Limit: 100. If this is specified, you cannot use any of the optional query parameters below.</param>
        public RequiredGetVideosID(List<string> id)
        {
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }

    public class RequiredGetVideosUSER : OptionSet<RequiredGetVideosUSER>
    {
        public string user_id { get; internal set; }

        /// <summary>
        /// RequiredGetVideosUSER
        /// </summary>
        /// <param name="user_id">ID of the user who owns the video. Limit 1.</param>
        public RequiredGetVideosUSER(string user_id)
        {
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }

    public class RequiredGetVideosGAME : OptionSet<RequiredGetVideosGAME>
    {
        public string game_id { get; internal set; }

        /// <summary>
        /// RequiredGetVideosGAME
        /// </summary>
        /// <param name="game_id">ID of the game the video is of. Limit 1.</param>
        public RequiredGetVideosGAME(string game_id)
        {
            this.game_id = game_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
