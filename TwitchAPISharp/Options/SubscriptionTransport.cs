using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options.Sub;

namespace TwitchAPISharp.Options
{
    public class SubscriptionTransport : SubOptions<SubscriptionTransport>
    {
        public string method { get; internal set; }
        public string callback { get; internal set; }
        public string secret { get; internal set; }

        public SubscriptionTransport(string callback, string secret, string method = "webhook")
        {

            this.method = method;
            this.callback = callback;
            this.secret = secret;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
