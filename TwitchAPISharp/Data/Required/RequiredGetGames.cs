using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetGames : OptionSet<RequiredGetGames>
    {
        public string id { get; internal set; }
        public string name { get; internal set; }

        /// <summary>
        /// RequiredGetGames
        /// </summary>
        /// <param name="id">Game ID. At most 100 id values can be specified.</param>
        /// <param name="name">Game name. The name must be an exact match. For example, “Pokemon” will not return a list of Pokemon games; instead, query any specific Pokemon games in which you are interested. At most 100 name values can be specified.</param>
        public RequiredGetGames(string id, string name)
        {
            this.id = id;
            this.name = name;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
