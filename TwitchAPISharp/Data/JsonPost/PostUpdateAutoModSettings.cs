using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostUpdateAutoModSettings : OptionSet<PostUpdateAutoModSettings>
    {
        public string overall_level { get; internal set; }

        /// <summary>
        /// PostUpdateAutoModSettings
        /// </summary>
        /// <param name="overall_level">missing</param>
        public PostUpdateAutoModSettings(string overall_level)
        {
            this.overall_level = overall_level;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
