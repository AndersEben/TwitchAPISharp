using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCost : OptionSet<PostCost>
    {
        public int amount { get; internal set; }
        public string type { get; internal set; }

        /// <summary>
        /// PostCost
        /// </summary>
        /// <param name="amount">Number of Bits for which the product will be exchanged. Minimum: 1, Maximum: 10000.</param>
        /// <param name="type">Cost type. The one valid value is "bits".</param>
        public PostCost(int amount, string type)
        {
            this.amount = amount;
            this.type = type;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
