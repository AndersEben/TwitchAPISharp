using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalGetEventSubSubscriptions : OptionSet<OptionalGetEventSubSubscriptions>
    {
        /// <summary>
        /// Filter subscriptions by its status. You may specify only one status value. Valid values are: 
        /// <para> enabled — The subscription is enabled. </para>
        /// <para> webhook_callback_verification_pending — The subscription is pending verification of the specified callback URL. </para>
        /// <para> webhook_callback_verification_failed — The specified callback URL failed verification. </para>
        /// <para> notification_failures_exceeded — The notification delivery failure rate was too high. </para>
        /// <para> authorization_revoked — The authorization was revoked for one or more users specified in the Condition object. </para>
        /// <para> user_removed — One of the users specified in the Condition object was removed. </para>
        /// </summary>
        public string status = null;
        /// <summary>
        /// Filter subscriptions by subscription type (e.g., channel.update). For a list of subscription types, see Subscription Types.
        /// </summary>
        public string type = null;
        /// <summary>
        /// The cursor used to get the next page of results. The pagination object in the response contains the cursor’s value.
        /// </summary>
        public string after = null;

    }
}
