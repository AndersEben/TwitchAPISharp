using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCustomRewards : OptionSet<PostCustomRewards>
    {
        public string title { get; internal set; }
        public int cost { get; internal set; }

        /// <summary>
        /// PostCustomRewards
        /// </summary>
        /// <param name="title">The title of the reward.</param>
        /// <param name="cost">The cost of the reward.</param>
        public PostCustomRewards(string title,  int cost)
        {
            this.title = title;
            this.cost = cost;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
