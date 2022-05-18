using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetUsers : OptionSet<OptionalGetUsers>
    {
        /// <summary>
        /// User ID. Multiple user IDs can be specified. Limit: 100.
        /// </summary>
        public List<string> id = null;
        /// <summary>
        /// User login name. Multiple login names can be specified. Limit: 100.
        /// </summary>
        public List<string> login = null;
    }
}
