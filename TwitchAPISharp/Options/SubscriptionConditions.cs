using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options
{
    public class SubscriptionConditions
    {
        public static readonly SubscriptionConditions broadcaster_user_id = new SubscriptionConditions("broadcaster_user_id");
        public static readonly SubscriptionConditions from_broadcaster_user_id = new SubscriptionConditions("from_broadcaster_user_id", false);
        public static readonly SubscriptionConditions to_broadcaster_user_id = new SubscriptionConditions("to_broadcaster_user_id", false);
        public static readonly SubscriptionConditions reward_id = new SubscriptionConditions("reward_id", false);
        public static readonly SubscriptionConditions category_id = new SubscriptionConditions("category_id", false);
        public static readonly SubscriptionConditions campaign_id = new SubscriptionConditions("campaign_id", false);
        public static readonly SubscriptionConditions organization_id = new SubscriptionConditions("organization_id");
        public static readonly SubscriptionConditions extension_client_id = new SubscriptionConditions("extension_client_id");
        public static readonly SubscriptionConditions client_id = new SubscriptionConditions("client_id");
        public static readonly SubscriptionConditions user_id = new SubscriptionConditions("user_id");

        private SubscriptionConditions(string condition, bool required = true)
        {
            this.condition = condition;
            this.required = required;
        }

        public string condition { get; private set; }
        public bool required { get; private set; }
    }
}
