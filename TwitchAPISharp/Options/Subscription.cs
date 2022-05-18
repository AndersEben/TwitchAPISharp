using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options.Sub.SubRequired;

namespace TwitchAPISharp.Options
{
    public class Subscription
    {
        public string type { get; internal set; }
        public string version { get; internal set; }
        public string condition { get; internal set; }
        public string transport { get; internal set; }

        public Subscription(SubscriptionTypes type, string version, Required_client client_id, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;
            this.condition = "{" + client_id.GetDataString() + "}";
            this.transport = "{" + transport.GetDataString() + "}";
        }
    }
}
