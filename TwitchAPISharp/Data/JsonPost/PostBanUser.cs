using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Data.Optional;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostBanUser : OptionSet<PostUpdateAutoModSettings>
    {
        public string data { get; internal set; }

        /// <summary>
        /// PostBanUser
        /// </summary>
        /// <param name="data">The user to ban or put in a timeout.</param>
        /// <param name="optional">To ban a user indefinitely, don’t include this field.</param>
        public PostBanUser(PostBanUserData data , OptionalBanUser optional = null)
        {

            string datastring = "{";
            datastring += data.GetDataString();

            if(optional!=null)
                datastring += optional.GetDataString(true);

            datastring += "}";

            this.data = datastring;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
