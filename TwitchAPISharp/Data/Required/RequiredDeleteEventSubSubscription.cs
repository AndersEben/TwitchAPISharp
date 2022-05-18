using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredDeleteEventSubSubscription : OptionSet<RequiredDeleteEventSubSubscription>
    {
        public string id { get; internal set; }

        /// <summary>
        /// RequiredDeleteEventSubSubscription
        /// </summary>
        /// <param name="id">The ID of the subscription to delete. This is the ID that Create Eventsub Subscription returns.</param>
        public RequiredDeleteEventSubSubscription(string id)
        {
            this.id = id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
