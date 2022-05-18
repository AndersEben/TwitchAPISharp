using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options
{
    public class SubscriptionTypes
    {

        public static readonly SubscriptionTypes channel_update = new SubscriptionTypes("channel.update");
        public static readonly SubscriptionTypes channel_follow = new SubscriptionTypes("channel.follow");
        public static readonly SubscriptionTypes channel_subscribe = new SubscriptionTypes("channel.subscribe");
        public static readonly SubscriptionTypes channel_subscription_end = new SubscriptionTypes("channel.subscription.end");
        public static readonly SubscriptionTypes channel_subscription_gift = new SubscriptionTypes("channel.subscription.gift");
        public static readonly SubscriptionTypes channel_subscription_message = new SubscriptionTypes("channel.subscription.message");
        public static readonly SubscriptionTypes channel_cheer = new SubscriptionTypes("channel.cheer");
        public static readonly SubscriptionTypes channel_raid = new SubscriptionTypes("channel.raid");
        public static readonly SubscriptionTypes channel_ban = new SubscriptionTypes("channel.ban");
        public static readonly SubscriptionTypes channel_unban = new SubscriptionTypes("channel.unban");
        public static readonly SubscriptionTypes channel_moderator_add = new SubscriptionTypes("channel.moderator.add");
        public static readonly SubscriptionTypes channel_moderator_remove = new SubscriptionTypes("channel.moderator.remove");
        public static readonly SubscriptionTypes channel_channel_points_custom_reward_add = new SubscriptionTypes("channel.channel_points_custom_reward.add");
        public static readonly SubscriptionTypes channel_channel_points_custom_reward_update = new SubscriptionTypes("channel.channel_points_custom_reward.update");
        public static readonly SubscriptionTypes channel_channel_points_custom_reward_remove = new SubscriptionTypes("channel.channel_points_custom_reward.remove");
        public static readonly SubscriptionTypes channel_channel_points_custom_reward_redemption_add = new SubscriptionTypes("channel.channel_points_custom_reward_redemption.add");
        public static readonly SubscriptionTypes channel_channel_points_custom_reward_redemption_update = new SubscriptionTypes("channel.channel_points_custom_reward_redemption.update");
        public static readonly SubscriptionTypes channel_poll_begin = new SubscriptionTypes("channel.poll.begin");
        public static readonly SubscriptionTypes channel_poll_progress = new SubscriptionTypes("channel.poll.progress");
        public static readonly SubscriptionTypes channel_poll_end = new SubscriptionTypes("channel.poll.end");
        public static readonly SubscriptionTypes channel_prediction_begin = new SubscriptionTypes("channel.prediction.begin");
        public static readonly SubscriptionTypes channel_prediction_progress = new SubscriptionTypes("channel.prediction.progress");
        public static readonly SubscriptionTypes channel_prediction_lock = new SubscriptionTypes("channel.prediction.lock");
        public static readonly SubscriptionTypes channel_prediction_end = new SubscriptionTypes("channel.prediction.end");
        public static readonly SubscriptionTypes drop_entitlement_grant = new SubscriptionTypes("drop.entitlement.grant");
        public static readonly SubscriptionTypes extension_bits_transaction_create = new SubscriptionTypes("extension.bits_transaction.create");
        public static readonly SubscriptionTypes channel_goal_begin = new SubscriptionTypes("channel.goal.begin");
        public static readonly SubscriptionTypes channel_goal_progress = new SubscriptionTypes("channel.goal.progress");
        public static readonly SubscriptionTypes channel_goal_end = new SubscriptionTypes("channel.goal.end");
        public static readonly SubscriptionTypes channel_hype_train_begin = new SubscriptionTypes("channel.hype_train.begin");
        public static readonly SubscriptionTypes channel_hype_train_progress = new SubscriptionTypes("channel.hype_train.progress");
        public static readonly SubscriptionTypes channel_hype_train_end = new SubscriptionTypes("channel.hype_train.end");
        public static readonly SubscriptionTypes stream_online = new SubscriptionTypes("stream.online");
        public static readonly SubscriptionTypes stream_offline = new SubscriptionTypes("stream.offline");
        public static readonly SubscriptionTypes user_authorization_grant = new SubscriptionTypes("user.authorization.grant");
        public static readonly SubscriptionTypes user_authorization_revoke = new SubscriptionTypes("user.authorization.revoke");
        public static readonly SubscriptionTypes user_update = new SubscriptionTypes("user.update");

        private SubscriptionTypes(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public List<SubscriptionConditions> Conditions { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
