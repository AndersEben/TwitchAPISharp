using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredSearchChannels : OptionSet<RequiredSearchChannels>
    {
        public string query { get; internal set; }

        /// <summary>
        /// RequiredSearchChannels
        /// </summary>
        /// <param name="query">URl encoded search query</param>
        public RequiredSearchChannels(string query)
        {
            this.query = query;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
