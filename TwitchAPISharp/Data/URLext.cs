using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data
{
    public class URLext
    {

        public static string ChannelsCommercial { get; } = "channels/commercial";
        public static string Channels { get; } = "channels";
        public static string ExtensionAnalytics { get; } = "analytics/extensions";
        public static string GameAnalytics { get; } = "analytics/games";
        public static string BitsLeaderboard { get; } = "bits/leaderboard";
        public static string Cheermotes { get; } = "bits/cheermotes";
        public static string ExtensionTransactions { get; } = "extensions/transactions";
        public static string ChannelEditors { get; } = "channels/editors";
        public static string CustomRewards { get; } = "channel_points/custom_rewards";
        public static string CustomRewardRedemption { get; } = "channel_points/custom_rewards/redemptions";
        public static string ChannelEmotes { get; } = "chat/emotes";
        public static string GlobalEmotes { get; } = "chat/emotes/global";
        public static string EmoteSets { get; } = "chat/emotes/set";
        public static string ChannelChatBadges { get; } = "chat/badges";
        public static string GlobalChatBadges { get; } = "chat/badges/global";
        public static string ChatSettings { get; } = "chat/settings";
        public static string Clip { get; } = "clips";
        public static string CodeStatus { get; } = "entitlements/codes";
        public static string DropsEntitlements { get; } = "entitlements/drops";
        public static string ExtensionConfigurationSegment { get; } = "extensions/configurations";
        public static string ExtensionRequiredConfiguration { get; } = "extensions/required_configuration";
        public static string ExtensionPubSubMessage { get; } = "extensions/pubsub";
        public static string ExtensionLiveChannels { get; } = "extensions/live";
        public static string ExtensionSecrets { get; } = "extensions/jwt/secrets";
        public static string ExtensionChatMessage { get; } = "extensions/chat";
        public static string Extensions { get; } = "extensions";
        public static string ReleasedExtensions { get; } = "extensions/released";
        public static string ExtensionBitsProducts { get; } = "bits/extensions";
        public static string EventSubSubscription { get; } = "eventsub/subscriptions";
        public static string TopGames { get; } = "games/top";
        public static string Games { get; } = "games";
        public static string CreatorGoals { get; } = "goals";
        public static string HypeTrainEvents { get; } = "hypetrain/events";
        public static string AutoModStatus { get; } = "moderation/enforcements/status";
        public static string HeldAutoModMessages { get; } = "moderation/automod/message";
        public static string AutoModSettings { get; } = "moderation/automod/settings";
        public static string BannedUsers { get; } = "moderation/banned";
        public static string BanUser { get; } = "moderation/bans";
        public static string BlockedTerms { get; } = "moderation/blocked_terms";
        public static string Moderators { get; } = "moderation/moderators";
        public static string Polls { get; } = "polls";
        public static string Predictions { get; } = "predictions";
        public static string ChannelStreamSchedule { get; } = "schedule";
        public static string ChanneliCalendar { get; } = "schedule/icalendar";
        public static string ChannelStreamScheduleSettings { get; } = "schedule/settings";
        public static string ChannelStreamScheduleSegment { get; } = "schedule/segment";
        public static string SearchCategories { get; } = "search/categories";
        public static string SearchChannels { get; } = "search/channels";
        public static string SoundtrackCurrentTrack { get; } = "soundtrack/current_track";
        public static string SoundtrackPlaylist { get; } = "soundtrack/playlist";
        public static string SoundtrackPlaylists { get; } = "soundtrack/playlists";
        public static string StreamKey { get; } = "streams/key";
        public static string Streams { get; } = "streams";
        public static string FollowedStreams { get; } = "streams/followed";
        public static string StreamMarker { get; } = "streams/markers";
        public static string BroadcasterSubscriptions { get; } = "subscriptions";
        public static string UserSubscription { get; } = "subscriptions/user";
        public static string AllStreamTags { get; } = "tags/streams";
        public static string StreamTags { get; } = "streams/tags";
        public static string ChannelTeams { get; } = "teams/channel";
        public static string Teams { get; } = "teams";
        public static string Users { get; } = "users";
        public static string UsersFollows { get; } = "users/follows";
        public static string UserBlockList { get; } = "users/blocks";
        public static string UserExtensions { get; } = "users/extensions/list";
        public static string UserActiveExtensions { get; } = "users/extensions";
        public static string Videos { get; } = "videos";

    }
}
