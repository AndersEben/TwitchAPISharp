using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetTeams : OptionSet<OptionalGetTeams>
    {
        /// <summary>
        /// Team name.
        /// </summary>
        public string name = null;
        /// <summary>
        /// Team ID.
        /// </summary>
        public string id = null;
    }
}
