using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetEmoteSets : OptionSet<RequiredGetEmoteSets>
    {
        public List<string> emote_set_id { get; internal set; }

        /// <summary>
        /// RequiredGetEmoteSets
        /// </summary>
        /// <param name="emote_set_id">An ID that identifies the emote set. Include the parameter for each emote set you want to get. For example, emote_set_id=1234&emote_set_id=5678. You may specify a maximum of 25 IDs.</param>
        public RequiredGetEmoteSets(List<string> emote_set_id)
        {
            this.emote_set_id = emote_set_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
