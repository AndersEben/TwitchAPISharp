using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetCheermotes : OptionSet<OptionalGetCheermotes>
    {
        /// <summary>
        /// ID for the broadcaster who might own specialized Cheermotes.
        /// </summary>
        public string broadcaster_id = null;
    }
}
