using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredSearchCategories : OptionSet<RequiredSearchCategories>
    {
        public string query { get; internal set; }

        /// <summary>
        /// RequiredSearchCategories
        /// </summary>
        /// <param name="query">URl encoded search query</param>
        public RequiredSearchCategories(string query)
        {
            this.query = query;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
