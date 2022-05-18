using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateUser : OptionSet<OptionalUpdateUser>
    {
        /// <summary>
        /// User’s account description
        /// </summary>
        public string description = null;
    }
}
