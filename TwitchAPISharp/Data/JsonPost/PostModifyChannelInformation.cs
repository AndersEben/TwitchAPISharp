using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostModifyChannelInformation : OptionSet<PostModifyChannelInformation>
    {
        public string game_id { get; internal set; }
        public string broadcaster_language { get; internal set; }
        public string title { get; internal set; }
        public int delay { get; internal set; }

        /// <summary>
        /// PostModifyChannelInformation
        /// </summary>
        /// <param name="game_id">The current game ID being played on the channel. Use “0” or “” (an empty string) to unset the game.</param>
        /// <param name="broadcaster_language">The language of the channel. A language value must be either the ISO 639-1 two-letter code for a supported stream language or “other”.</param>
        /// <param name="title">The title of the stream. Value must not be an empty string.</param>
        /// <param name="delay">Stream delay in seconds. Stream delay is a Twitch Partner feature; trying to set this value for other account types will return a 400 error.</param>
        public PostModifyChannelInformation(string game_id, StreamLanguage broadcaster_language, string title, int delay)
        {
            this.game_id = game_id;
            this.broadcaster_language = broadcaster_language.ToString();
            this.title = title;
            this.delay = delay;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
