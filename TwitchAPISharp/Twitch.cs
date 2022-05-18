using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchAPISharp.Data;
using TwitchAPISharp.Data.JsonPost;
using TwitchAPISharp.Data.JsonResponse;
using TwitchAPISharp.Data.Optional;
using TwitchAPISharp.Data.Required;
using TwitchAPISharp.Options;

namespace TwitchAPISharp
{
    public class Twitch
    {

        /// <summary>
        /// Twitch Token will set by TwitchClass call
        /// </summary>
        public string Token { get; internal set; }

        /// <summary>
        /// TokenType will be set by TwitchClass call
        /// </summary>
        public TokenType tokenType { get; internal set; }

        /// <summary>
        /// ClientId will be set by TwitchClass call
        /// </summary>
        public string ClientID { get; internal set; }

        private string BaseURL { get; } = "https://api.twitch.tv/helix/";


        /// <summary>
        /// Creates a new instance of the Twitch Class
        /// </summary>
        /// <param name="token"></param>
        /// <param name="type"></param>
        /// <param name="clientID"></param>
        public Twitch(string token, TokenType type, string clientID)
        {
            this.Token = token;
            this.tokenType = type;
            this.ClientID = clientID;
        }

        /// <summary>
        /// Starts a commercial on a specified channel.
        /// <para>Required scope:</para>
        /// channel:edit:commercial
        /// <para>OAuth Token required</para>
        /// </summary>
        /// <param name="post">PostStartCommercial</param>
        /// <returns></returns>
        public ResponseStartCommercialData StartCommercial(PostStartCommercial post)
        {

            ResponseStartCommercialData result = null;

            string url = BaseURL + URLext.ChannelsCommercial;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseStartCommercialData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a URL that Extension developers can use to download analytics reports (CSV files) for their Extensions. The URL is valid for 5 minutes.
        /// <para>Required scope:</para>
        /// analytics:read:extensions
        /// <para>OAuth Token required</para>
        /// </summary>
        /// <param name="optional">OptionalGetExtensionAnalytics</param>
        /// <returns></returns>
        public ResponseGetExtensionAnalyticsData GetExtensionAnalytics(OptionalGetExtensionAnalytics optional = null)
        {

            ResponseGetExtensionAnalyticsData result = null;

            string url = BaseURL + URLext.ExtensionAnalytics;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionAnalyticsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a URL that game developers can use to download analytics reports (CSV files) for their games. The URL is valid for 5 minutes. For detail about analytics and the fields returned, see the Insights & Analytics guide.
        /// <para>Required scope:</para>
        /// analytics:read:game
        /// <para>OAuth Token required</para>
        /// </summary>
        /// <param name="optional">OptionalGetGameAnalytics</param>
        /// <returns></returns>
        public ResponseGetGameAnalyticssData GetGameAnalytics(OptionalGetGameAnalytics optional = null)
        {
            ResponseGetGameAnalyticssData result = null;

            string url = BaseURL + URLext.GameAnalytics;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetGameAnalyticssData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a ranked list of Bits leaderboard information for an authorized broadcaster.
        /// <para>Required scope:</para>
        /// bits:read
        /// <para>OAuth Token required</para>
        /// </summary>
        /// <param name="optional">OptionalGetBitsLeaderboard</param>
        /// <returns></returns>
        public ResponseGetBitsLeaderboardData GetBitsLeaderboard(OptionalGetBitsLeaderboard optional = null)
        {
            ResponseGetBitsLeaderboardData result = null;

            string url = BaseURL + URLext.BitsLeaderboard;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetBitsLeaderboardData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Retrieves the list of available Cheermotes, animated emotes to which viewers can assign Bits, to cheer in chat. Cheermotes returned are available throughout Twitch, in all Bits-enabled channels.
        /// <para>OAuth or App Access Token required.</para>
        /// </summary>
        /// <param name="optional">OptionalGetCheermotes</param>
        /// <returns></returns>
        public ResponseGetCheermotesData GetCheermotes(OptionalGetCheermotes optional = null)
        {
            ResponseGetCheermotesData result = null;

            string url = BaseURL + URLext.Cheermotes;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetCheermotesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the list of Extension transactions for a given Extension. This allows Extension back-end servers to fetch a list of transactions that have occurred for their Extension across all of Twitch. A transaction is a record of a user exchanging Bits for an in-Extension digital good.
        /// <para>App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetExtensionTransactions</param>
        /// <param name="optional">OptionalGetExtensionTransactions</param>
        /// <returns></returns>
        public ResponseGetExtensionTransactionsData GetExtensionTransactions(RequiredGetExtensionTransactions required, OptionalGetExtensionTransactions optional = null)
        {
            ResponseGetExtensionTransactionsData result = null;

            string url = BaseURL + URLext.ExtensionTransactions;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionTransactionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets channel information for users.
        /// <para>Valid user token or app access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetChannelInformation</param>
        /// <returns></returns>
        public ResponseGetChannelInformationData GetChannelInformation(RequiredGetChannelInformation required)
        {
            ResponseGetChannelInformationData result = null;

            string url = BaseURL + URLext.Channels;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChannelInformationData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Modifies channel information for users.
        /// <para>Required scope:</para>
        /// channel:manage:broadcast
        /// <para>OAuth Token required</para>
        /// </summary>
        /// <param name="required">RequiredModifyChannelInformation</param>
        /// <param name="post">PostModifyChannelInformation</param>
        /// <returns></returns>
        public bool ModifyChannelInformation(RequiredModifyChannelInformation required, PostModifyChannelInformation post)
        {

            bool result = false;

            string url = BaseURL + URLext.Channels;

            url += required.GetString();

            var dataRaw = JObject.Parse(post.GetString()).ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var puffer = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of users who have editor permissions for a specific channel.
        /// <para>Required scope:</para>
        /// channel:read:editors
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="required">RequiredChannelEditors</param>
        /// <returns></returns>
        public ResponseChannelEditorsData GetChannelEditors(RequiredChannelEditors required)
        {
            ResponseChannelEditorsData result = null;

            string url = BaseURL + URLext.ChannelEditors;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseChannelEditorsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Creates a Custom Reward on a channel.
        /// <para>Required scope:</para>
        /// channel:manage:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredCreateCustomRewards</param>
        /// <param name="post">PostCustomRewards</param>
        /// <param name="optinal">OptionalCustomRewards</param>
        /// <returns></returns>
        public ResponseCreateCustomRewardsData CreateCustomRewards(RequiredCreateCustomRewards required, PostCustomRewards post, OptionalCustomRewards optinal = null)
        {

            ResponseCreateCustomRewardsData result = null;

            string url = BaseURL + URLext.CustomRewards;

            url += required.GetString();

            string dataString = post.GetDataString();

            if (optinal != null)
                dataString += optinal.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateCustomRewardsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Deletes a Custom Reward on a channel.
        /// The Custom Reward specified by id must have been created by the client_id attached to the OAuth token in order to be deleted.Any UNFULFILLED Custom Reward Redemptions of the deleted Custom Reward will be updated to the FULFILLED status.
        /// <para>Required scope:</para>
        /// channel:manage:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredDeleteCustomReward</param>
        /// <returns></returns>
        public bool DeleteCustomReward(RequiredDeleteCustomReward required)
        {

            bool result = false;

            string url = BaseURL + URLext.CustomRewards;

            url += required.GetString();

            var download = Functions.DELETERequest(Token, ClientID, url, "", tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var puffer = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns a list of Custom Reward objects for the Custom Rewards on a channel.
        /// <para>Required scope:</para>
        /// channel:read:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredGetCustomReward</param>
        /// <param name="optional">OptionalGetCustomReward</param>
        /// <returns></returns>
        public ResponseGetCustomRewardData GetCustomReward(RequiredGetCustomReward required, OptionalGetCustomReward optional = null)
        {
            ResponseGetCustomRewardData result = null;

            string url = BaseURL + URLext.CustomRewards;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetCustomRewardData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns Custom Reward Redemption objects for a Custom Reward on a channel that was created by the same client_id.
        /// <para>Required scope:</para>
        /// channel:read:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredGetCustomRewardRedemption</param>
        /// <param name="optional">OptionalGetCustomRewardRedemption</param>
        /// <returns></returns>
        public ResponseGetCustomRewardRedemptionData GetCustomRewardRedemption(RequiredGetCustomRewardRedemption required, OptionalGetCustomRewardRedemption optional = null)
        {
            ResponseGetCustomRewardRedemptionData result = null;

            string url = BaseURL + URLext.CustomRewardRedemption;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetCustomRewardRedemptionData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates a Custom Reward created on a channel.
        /// The Custom Reward specified by id must have been created by the client_id attached to the user OAuth token.
        /// <para>Required scope:</para>
        /// channel:read:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredUpdateCustomReward</param>
        /// <param name="optional">OptionalUpdateCustomReward</param>
        /// <returns></returns>
        public ResponseUpdateCustomRewardData UpdateCustomReward(RequiredUpdateCustomReward required, OptionalUpdateCustomReward optional = null)
        {
            ResponseUpdateCustomRewardData result = null;

            string url = BaseURL + URLext.CustomRewards;

            url += required.GetString();

            string dataString = "";

            if (optional != null)
                dataString += optional.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateCustomRewardData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the status of Custom Reward Redemption objects on a channel that are in the UNFULFILLED status.
        /// The Custom Reward Redemption specified by id must be for a Custom Reward created by the client_id attached to the user OAuth token.
        /// <para>Required scope:</para>
        /// channel:read:redemptions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredUpdateRedemptionStatus</param>
        /// <param name="post">PostUpdateRedemptionStatus</param>
        /// <returns></returns>
        public ResponseUpdateRedemptionStatusData UpdateRedemptionStatus(RequiredUpdateRedemptionStatus required, PostUpdateRedemptionStatus post)
        {
            ResponseUpdateRedemptionStatusData result = null;

            string url = BaseURL + URLext.CustomRewardRedemption;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateRedemptionStatusData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets all emotes that the specified Twitch channel created. Broadcasters create these custom emotes for users who subscribe to or follow the channel, or cheer Bits in the channel’s chat window. For information about the custom emotes, see subscriber emotes, Bits tier emotes, and follower emotes.
        /// <para>Requires a user or application OAuth access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetChannelEmotes</param>
        /// <returns></returns>
        public ResponseGetChannelEmotesData GetChannelEmotes(RequiredGetChannelEmotes required)
        {
            ResponseGetChannelEmotesData result = null;

            string url = BaseURL + URLext.ChannelEmotes;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChannelEmotesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets all global emotes. Global emotes are Twitch-created emoticons that users can use in any Twitch chat.
        /// <para>Requires a user or application OAuth access token.</para>
        /// </summary>
        /// <returns></returns>
        public ResponseGetGlobalEmotesData GetGlobalEmotes()
        {
            ResponseGetGlobalEmotesData result = null;

            string url = BaseURL + URLext.GlobalEmotes;

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetGlobalEmotesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets emotes for one or more specified emote sets.
        /// An emote set groups emotes that have a similar context.For example, Twitch places all the subscriber emotes that a broadcaster uploads for their channel in the same emote set.
        /// <para>Requires a user or application OAuth access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetEmoteSets</param>
        /// <returns></returns>
        public ResponseGetEmoteSetsData GetEmoteSets(RequiredGetEmoteSets required)
        {
            ResponseGetEmoteSetsData result = null;

            string url = BaseURL + URLext.EmoteSets;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetEmoteSetsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of custom chat badges that can be used in chat for the specified channel. This includes subscriber badges and Bit badges.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetChannelChatBadges</param>
        /// <returns></returns>
        public ResponseGetChannelChatBadgesData GetChannelChatBadges(RequiredGetChannelChatBadges required)
        {
            ResponseGetChannelChatBadgesData result = null;

            string url = BaseURL + URLext.ChannelChatBadges;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChannelChatBadgesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of chat badges that can be used in chat for any channel.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <returns></returns>
        public ResponseGetGlobalChatBadgesData GetGlobalChatBadges()
        {
            ResponseGetGlobalChatBadgesData result = null;

            string url = BaseURL + URLext.GlobalChatBadges;

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetGlobalChatBadgesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the broadcaster’s chat settings.
        /// <para>Requires an App access token</para>
        /// </summary>
        /// <param name="required">RequiredGetChatSettings</param>
        /// <param name="optional">OptionalGetChatSettings</param>
        /// <returns></returns>
        public ResponseGetChatSettingsData GetChatSettings(RequiredGetChatSettings required, OptionalGetChatSettings optional = null)
        {
            ResponseGetChatSettingsData result = null;

            string url = BaseURL + URLext.ChatSettings;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChatSettingsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the broadcaster’s chat settings.
        /// <para>Required scope:</para>
        /// moderator:manage:chat_settings
        /// <para>Requires User access token</para>
        /// </summary>
        /// <param name="required">RequiredUpdateChatSettings</param>
        /// <param name="post">PostUpdateChatSettings</param>
        /// <returns></returns>
        public ResponseUpdateChatSettingsData UpdateChatSettings(RequiredUpdateChatSettings required, PostUpdateChatSettings post)
        {
            ResponseUpdateChatSettingsData result = null;

            string url = BaseURL + URLext.ChatSettings;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateChatSettingsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Creates a clip programmatically. This returns both an ID and an edit URL for the new clip.
        /// <para>Required scope:</para>
        /// clips:edit
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="required">RequiredCreateClip</param>
        /// <param name="optinal">OptionalCreateClip</param>
        /// <returns></returns>
        public ResponseCreateClipData CreateClip(RequiredCreateClip required, OptionalCreateClip optinal = null)
        {

            ResponseCreateClipData result = null;

            string url = BaseURL + URLext.Clip;

            url += required.GetString();

            string dataString = "";

            if (optinal != null)
                url += optinal.GetString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateClipData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets clip information by clip ID (one or more), broadcaster ID (one only), or game ID (one only).
        /// <para>OAuth or App Access Token required.</para>
        /// </summary>
        /// <param name="required">RequiredGetClips</param>
        /// <param name="optional">OptionalGetClips</param>
        /// <returns></returns>
        public ResponseGetClipsData GetClips(RequiredGetClips required, OptionalGetClips optional = null)
        {
            ResponseGetClipsData result = null;

            string url = BaseURL + URLext.Clip;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetClipsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the status of one or more provided codes. This API requires that the caller is an authenticated Twitch user. 
        /// The API is throttled to one request per second per authenticated user. Codes are redeemable alphanumeric strings tied only to the bits product. This third-party API allows other parties to redeem codes on behalf of users. 
        /// Third-party app and extension developers can use the API to provide rewards of bits from within their games.
        /// </summary>
        /// <param name="required">RequiredGetCodeStatus</param>
        /// <returns></returns>
        public ResponseGetCodeStatusData GetCodeStatus(RequiredGetCodeStatus required)
        {
            ResponseGetCodeStatusData result = null;

            string url = BaseURL + URLext.CodeStatus;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetCodeStatusData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of entitlements for a given organization that have been granted to a game, user, or both.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="optional">OptionalGetDropsEntitlements</param>
        /// <returns></returns>
        public ResponseGetDropsEntitlementsData GetDropsEntitlements(OptionalGetDropsEntitlements optional = null)
        {
            ResponseGetDropsEntitlementsData result = null;

            string url = BaseURL + URLext.DropsEntitlements;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetDropsEntitlementsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the fulfillment status on a set of Drops entitlements, specified by their entitlement IDs.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="optional">OptionalUpdateDropsEntitlements</param>
        /// <returns></returns>
        public ResponseUpdateDropsEntitlementsData UpdateDropsEntitlements(OptionalUpdateDropsEntitlements optional = null)
        {
            ResponseUpdateDropsEntitlementsData result = null;

            string url = BaseURL + URLext.DropsEntitlements;

            string dataString = "";

            if (optional != null)
                dataString += optional.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateDropsEntitlementsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Redeems one or more redemption codes. Redeeming a code credits the user’s account with the entitlement associated with the code. For example, a Bits reward earned when playing a game.
        /// </summary>
        /// <param name="required">RequiredRedeemCode</param>
        /// <returns></returns>
        public ResponseRedeemCodeData RedeemCode(RequiredRedeemCode required)
        {

            ResponseRedeemCodeData result = null;

            string url = BaseURL + URLext.CodeStatus;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseRedeemCodeData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the specified configuration segment from the specified extension.
        /// </summary>
        /// <param name="required">RequiredGetExtensionConfigurationSegment</param>
        /// <returns></returns>
        public ResponseGetExtensionConfigurationSegmentData GetExtensionConfigurationSegment(RequiredGetExtensionConfigurationSegment required)
        {
            ResponseGetExtensionConfigurationSegmentData result = null;

            string url = BaseURL + URLext.ExtensionConfigurationSegment;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionConfigurationSegmentData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Sets a single configuration segment of any type. The segment type is specified as a body parameter.
        /// </summary>
        /// <param name="post">PostSetExtensionConfigurationSegment</param>
        /// <param name="optional">OptionalSetExtensionConfigurationSegment</param>
        /// <returns></returns>
        public bool SetExtensionConfigurationSegment(PostSetExtensionConfigurationSegment post, OptionalSetExtensionConfigurationSegment optional = null)
        {

            bool result = false;

            string url = BaseURL + URLext.ExtensionConfigurationSegment;

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Enable activation of a specified Extension, after any required broadcaster configuration is correct. 
        /// The Extension is identified by a client ID value assigned to the Extension when it is created. 
        /// This is for Extensions that require broadcaster configuration before activation. 
        /// Use this if, in Extension Capabilities, you select Custom/My Own Service.
        /// </summary>
        /// <param name="required">RequiredSetExtensionRequiredConfiguration</param>
        /// <param name="post">PostSetExtensionRequiredConfiguration</param>
        /// <returns></returns>
        public bool SetExtensionRequiredConfiguration(RequiredSetExtensionRequiredConfiguration required, PostSetExtensionRequiredConfiguration post)
        {

            bool result = false;

            string url = BaseURL + URLext.ExtensionRequiredConfiguration;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Twitch provides a publish-subscribe system for your EBS to communicate with both the broadcaster and viewers. 
        /// Calling this endpoint forwards your message using the same mechanism as the send JavaScript helper function. 
        /// A message can be sent to either a specified channel or globally (all channels on which your extension is active).
        /// </summary>
        /// <param name="post">PostSendExtensionPubSubMessage</param>
        /// <returns></returns>
        public bool SendExtensionPubSubMessage(PostSendExtensionPubSubMessage post)
        {

            bool result = false;

            string url = BaseURL + URLext.ExtensionPubSubMessage;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns one page of live channels that have installed or activated a specific Extension, identified by a client ID value assigned to the Extension when it is created.
        /// A channel that recently went live may take a few minutes to appear in this list, and a channel may continue to appear on this list for a few minutes after it stops broadcasting.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetExtensionLiveChannels</param>
        /// <param name="optional">OptionalGetExtensionLiveChannels</param>
        /// <returns></returns>
        public ResponseGetExtensionLiveChannelsData GetExtensionLiveChannels(RequiredGetExtensionLiveChannels required, OptionalGetExtensionLiveChannels optional = null)
        {
            ResponseGetExtensionLiveChannelsData result = null;

            string url = BaseURL + URLext.ExtensionLiveChannels;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionLiveChannelsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Retrieves a specified Extension’s secret data consisting of a version and an array of secret objects. 
        /// Each secret object contains a base64-encoded secret, a UTC timestamp when the secret becomes active, and a timestamp when the secret expires.
        /// </summary>
        /// <param name="required">RequiredGetExtensionSecrets</param>
        /// <returns></returns>
        public ResponseGetExtensionSecretsData GetExtensionSecrets(RequiredGetExtensionSecrets required)
        {
            ResponseGetExtensionSecretsData result = null;

            string url = BaseURL + URLext.ExtensionSecrets;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionSecretsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Creates a JWT signing secret for a specific Extension. Also rotates any current secrets out of service, 
        /// with enough time for instances of the Extension to gracefully switch over to the new secret. 
        /// Use this function only when you are ready to install the new secret it returns.
        /// </summary>
        /// <param name="required">RequiredCreateExtensionSecret</param>
        /// <param name="optional">OptionalCreateExtensionSecret</param>
        /// <returns></returns>
        public ResponseCreateExtensionSecretData CreateExtensionSecret(RequiredCreateExtensionSecret required, OptionalCreateExtensionSecret optional = null)
        {

            ResponseCreateExtensionSecretData result = null;

            string url = BaseURL + URLext.ExtensionSecrets;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateExtensionSecretData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Sends a specified chat message to a specified channel. The message will appear in the channel’s chat as a normal message. 
        /// The “username” of the message is the Extension name.
        /// <para>There is a limit of 12 messages per minute, per channel. Extension chat messages use the same rate-limiting functionality as the Twitch API </para>
        /// </summary>
        /// <param name="required">RequiredSendExtensionChatMessage</param>
        /// <param name="post">PostSendExtensionChatMessage</param>
        /// <returns></returns>
        public bool SendExtensionChatMessage(RequiredSendExtensionChatMessage required, PostSendExtensionChatMessage post)
        {

            bool result = false;

            string url = BaseURL + URLext.ExtensionChatMessage;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about your Extensions; either the current version or a specified version.
        /// </summary>
        /// <param name="required">RequiredGetExtensions</param>
        /// <param name="optional">OptionalGetExtensions</param>
        /// <returns></returns>
        public ResponseGetExtensions GetExtensions(RequiredGetExtensions required, OptionalGetExtensions optional = null)
        {
            ResponseGetExtensions result = null;

            string url = BaseURL + URLext.Extensions;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensions>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about a released Extension; either the current version or a specified version.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetReleasedExtensions</param>
        /// <param name="optional">OptionalGetReleasedExtensions</param>
        /// <returns></returns>
        public ResponseGetReleasedExtensionsData GetReleasedExtensions(RequiredGetReleasedExtensions required, OptionalGetReleasedExtensions optional = null)
        {
            ResponseGetReleasedExtensionsData result = null;

            string url = BaseURL + URLext.ReleasedExtensions;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetReleasedExtensionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of Bits products that belongs to an Extension.
        /// <para>App Access Token associated with the Extension client ID</para>
        /// </summary>
        /// <param name="optional">OptionalGetExtensionBitsProducts</param>
        /// <returns></returns>
        public ResponseGetExtensionBitsProductsData GetExtensionBitsProducts(OptionalGetExtensionBitsProducts optional = null)
        {
            ResponseGetExtensionBitsProductsData result = null;

            string url = BaseURL + URLext.Extensions;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetExtensionBitsProductsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Add or update a Bits products that belongs to an Extension.
        /// <para>App Access Token associated with the Extension client ID</para>
        /// </summary>
        /// <param name="post">PostUpdateExtensionBitsProduct</param>
        /// <param name="optional">OptionalUpdateExtensionBitsProduct</param>
        /// <returns></returns>
        public ResponseUpdateExtensionBitsProductData UpdateExtensionBitsProduct(PostUpdateExtensionBitsProduct post, OptionalUpdateExtensionBitsProduct optional = null)
        {

            ResponseUpdateExtensionBitsProductData result = null;

            string url = BaseURL + URLext.Extensions;

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateExtensionBitsProductData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Creates an EventSub subscription.
        /// <para>Required scope:</para>
        /// channel:read:subscriptions
        /// <para>Requires an app access token.</para>
        /// </summary>
        /// <param name="post">PostCreateEventSubSubscription</param>
        /// <returns></returns>
        public ResponseCreateEventSubSubscriptionData CreateEventSubSubscription(PostCreateEventSubSubscription post)
        {

            ResponseCreateEventSubSubscriptionData result = null;

            string url = BaseURL + URLext.EventSubSubscription;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateEventSubSubscriptionData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Deletes an EventSub subscription.
        /// <para>Requires an application OAuth access token.</para>
        /// </summary>
        /// <param name="required">RequiredDeleteEventSubSubscription</param>
        /// <returns></returns>
        public bool DeleteEventSubSubscription(RequiredDeleteEventSubSubscription required)
        {

            bool result = false;

            string url = BaseURL + URLext.EventSubSubscription;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of your EventSub subscriptions. The list is paginated and ordered by the oldest subscription first.
        /// <para>Requires an application OAuth access token.</para>
        /// </summary>
        /// <param name="optional">OptionalGetEventSubSubscriptions</param>
        /// <returns></returns>
        public ResponseGetEventSubSubscriptionsData GetEventSubSubscriptions(OptionalGetEventSubSubscriptions optional = null)
        {
            ResponseGetEventSubSubscriptionsData result = null;

            string url = BaseURL + URLext.EventSubSubscription;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetEventSubSubscriptionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets games sorted by number of current viewers on Twitch, most popular first.
        /// <para>OAuth or App Access Token required.</para>
        /// </summary>
        /// <param name="optional">OptionalGetEventSubSubscriptions</param>
        /// <returns></returns>
        public ResponseGetTopGamesData GetTopGames(OptionalGetTopGames optional = null)
        {
            ResponseGetTopGamesData result = null;

            string url = BaseURL + URLext.TopGames;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetTopGamesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets game information by game ID or name.
        /// <para>OAuth or App Access Token required.</para>
        /// </summary>
        /// <param name="required">RequiredGetGames</param>
        /// <returns></returns>
        public ResponseGetGamesData GetGames(RequiredGetGames required)
        {
            ResponseGetGamesData result = null;

            string url = BaseURL + URLext.Games;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetGamesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the broadcaster’s list of active goals. Use this to get the current progress of each goal.
        /// <para>Required scope:</para>
        /// channel:read:goals
        /// <para>Requires a user OAuth access token</para>
        /// </summary>
        /// <param name="required">RequiredGetCreatorGoals</param>
        /// <returns></returns>
        public ResponseGetCreatorGoalsData GetCreatorGoals(RequiredGetCreatorGoals required)
        {
            ResponseGetCreatorGoalsData result = null;

            string url = BaseURL + URLext.CreatorGoals;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetCreatorGoalsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the information of the most recent Hype Train of the given channel ID.
        /// When there is currently an active Hype Train, it returns information about that Hype Train. 
        /// When there is currently no active Hype Train, it returns information about the most recent Hype Train. 
        /// After 5 days, if no Hype Train has been active, the endpoint will return an empty response.
        /// <para>Required scope:</para>
        /// channel:read:hype_train
        /// <para>User OAuth Token</para>
        /// </summary>
        /// <param name="required">RequiredGetHypeTrainEvents</param>
        /// <param name="optional">OptionalGetHypeTrainEvents</param>
        /// <returns></returns>
        public ResponseGetHypeTrainEventsData GetHypeTrainEvents(RequiredGetHypeTrainEvents required, OptionalGetHypeTrainEvents optional = null)
        {
            ResponseGetHypeTrainEventsData result = null;

            string url = BaseURL + URLext.HypeTrainEvents;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetHypeTrainEventsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Determines whether a string message meets the channel’s AutoMod requirements.
        /// <para>Required scope:</para>
        /// moderation:read
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="post">PostCheckAutoModStatus</param>
        /// <param name="required">RequiredCheckAutoModStatus</param>
        /// <returns></returns>
        public ResponseCheckAutoModStatusData CheckAutoModStatus(PostCheckAutoModStatus post, RequiredCheckAutoModStatus required)
        {

            ResponseCheckAutoModStatusData result = null;

            string url = BaseURL + URLext.AutoModStatus;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCheckAutoModStatusData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Allow or deny a message that was held for review by AutoMod.
        /// <para>Required scope:</para>
        /// moderator:manage:automod
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="post">PostManageHeldAutoModMessages</param>
        /// <returns></returns>
        public bool ManageHeldAutoModMessages(PostManageHeldAutoModMessages post)
        {

            bool result = false;

            string url = BaseURL + URLext.HeldAutoModMessages;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the broadcaster’s AutoMod settings, which are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.
        /// <para>Required scope:</para>
        /// moderator:read:automod_settings
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="required">RequiredGetAutoModSettings</param>
        /// <returns></returns>
        public ResponseGetAutoModSettingsData GetAutoModSettings(RequiredGetAutoModSettings required)
        {
            ResponseGetAutoModSettingsData result = null;

            string url = BaseURL + URLext.AutoModSettings;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetAutoModSettingsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the broadcaster’s AutoMod settings, which are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.
        /// <para>Required scope:</para>
        /// moderator:manage:automod_settings
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="post">PostUpdateAutoModSettings</param>
        /// <param name="required">RequiredUpdateAutoModSettings</param>
        /// <returns></returns>
        public ResponseUpdateAutoModSettingsData UpdateAutoModSettings(PostUpdateAutoModSettings post, RequiredUpdateAutoModSettings required)
        {

            ResponseUpdateAutoModSettingsData result = null;

            string url = BaseURL + URLext.AutoModStatus;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateAutoModSettingsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns all banned and timed-out users for a channel.
        /// <para>Required scope:</para>
        /// moderation:read
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="required">RequiredGetBannedUsers</param>
        /// <param name="optional">OptionalGetBannedUsers</param>
        /// <returns></returns>
        public ResponseGetBannedUsersData GetBannedUsers(RequiredGetBannedUsers required, OptionalGetBannedUsers optional = null)
        {
            ResponseGetBannedUsersData result = null;

            string url = BaseURL + URLext.BannedUsers;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetBannedUsersData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Bans a user from participating in a broadcaster’s chat room, or puts them in a timeout. For more information about banning or putting users in a timeout, see Ban a User and Timeout a User.
        /// <para>Required scope:</para>
        /// moderator:manage:banned_users
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="post">PostBanUser</param>
        /// <param name="required">RequiredBanUser</param>
        /// <returns></returns>
        public ResponseBanUserData BanUser(PostBanUser post, RequiredBanUser required)
        {

            ResponseBanUserData result = null;

            string url = BaseURL + URLext.BanUser;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseBanUserData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Removes the ban or timeout that was placed on the specified user
        /// <para>Required scope:</para>
        /// moderator:manage:banned_users
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="required">RequiredUnbanUser</param>
        /// <returns></returns>
        public bool UnbanUser(RequiredUnbanUser required)
        {

            bool result = false;

            string url = BaseURL + URLext.BanUser;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the broadcaster’s list of non-private, blocked words or phrases. These are the terms that the broadcaster or moderator added manually, or that were denied by AutoMod.
        /// <para>Required scope:</para>
        /// moderator:read:blocked_terms
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="required">RequiredGetBlockedTerms</param>
        /// <param name="optional">OptionalGetBlockedTerms</param>
        /// <returns></returns>
        public ResponseGetBlockedTermsData GetBlockedTerms(RequiredGetBlockedTerms required, OptionalGetBlockedTerms optional = null)
        {
            ResponseGetBlockedTermsData result = null;

            string url = BaseURL + URLext.BlockedTerms;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetBlockedTermsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms. These are the terms that broadcasters don’t want used in their chat room.
        /// <para>Required scope:</para>
        /// moderator:manage:blocked_terms
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="post">PostAddBlockedTerm</param>
        /// <param name="required">RequiredAddBlockedTerm</param>
        /// <returns></returns>
        public ResponseAddBlockedTermData AddBlockedTerm(PostAddBlockedTerm post, RequiredAddBlockedTerm required)
        {

            ResponseAddBlockedTermData result = null;

            string url = BaseURL + URLext.BlockedTerms;

            url += required.GetString();

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseAddBlockedTermData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Removes the word or phrase that the broadcaster is blocking users from using in their chat room.
        /// <para>Required scope:</para>
        /// moderator:manage:blocked_terms
        /// <para>Requires a User access token</para>
        /// </summary>
        /// <param name="required">RequiredRemoveBlockedTerm</param>
        /// <returns></returns>
        public bool RemoveBlockedTerm(RequiredRemoveBlockedTerm required)
        {

            bool result = false;

            string url = BaseURL + URLext.BlockedTerms;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns all moderators in a channel. Note: This endpoint does not return the broadcaster in the response, as broadcasters are channel owners and have all permissions of moderators implicitly.
        /// <para>Required scope:</para>
        /// moderation:read
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="required">RequiredGetModerators</param>
        /// <param name="optional">OptionalGetModerators</param>
        /// <returns></returns>
        public ResponseGetModeratorsData GetModerators(RequiredGetModerators required, OptionalGetModerators optional = null)
        {
            ResponseGetModeratorsData result = null;

            string url = BaseURL + URLext.Moderators;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetModeratorsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Get information about all polls or specific polls for a Twitch channel. Poll information is available for 90 days.
        /// <para>Required scope:</para>
        /// channel:read:polls
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredGetPolls</param>
        /// <param name="optional">OptionalGetPolls</param>
        /// <returns></returns>
        public ResponseGetPollsData GetPolls(RequiredGetPolls required, OptionalGetPolls optional = null)
        {
            ResponseGetPollsData result = null;

            string url = BaseURL + URLext.Polls;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetPollsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Create a poll for a specific Twitch channel.
        /// <para>Required scope:</para>
        /// channel:manage:polls
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="post">PostCreatePoll</param>
        /// <param name="optional">OptionalCreatePoll</param>
        /// <returns></returns>
        public ResponseCreatePollData CreatePoll(PostCreatePoll post, OptionalCreatePoll optional = null)
        {

            ResponseCreatePollData result = null;

            string url = BaseURL + URLext.Polls;

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreatePollData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// End a poll that is currently active.
        /// <para>Required scope:</para>
        /// channel:manage:polls
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="post">PostEndPoll</param>
        /// <returns></returns>
        public ResponseEndPollData EndPoll(PostEndPoll post)
        {

            ResponseEndPollData result = null;

            string url = BaseURL + URLext.Polls;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseEndPollData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Get information about all Channel Points Predictions or specific Channel Points Predictions for a Twitch channel. 
        /// Results are ordered by most recent, so it can be assumed that the currently active or locked Prediction will be the first item.
        /// <para>Required scope:</para>
        /// channel:read:predictions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredGetPredictions</param>
        /// <param name="optional">OptionalGetPredictions</param>
        /// <returns></returns>
        public ResponseGetPredictionsData GetPredictions(RequiredGetPredictions required, OptionalGetPredictions optional = null)
        {
            ResponseGetPredictionsData result = null;

            string url = BaseURL + URLext.Predictions;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetPredictionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Create a Channel Points Prediction for a specific Twitch channel.
        /// <para>Required scope:</para>
        /// channel:manage:predictions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="post">PostCreatePrediction</param>
        /// <returns></returns>
        public ResponseCreatePredictionData CreatePrediction(PostCreatePrediction post)
        {

            ResponseCreatePredictionData result = null;

            string url = BaseURL + URLext.Predictions;

            string dataString = post.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreatePredictionData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Lock, resolve, or cancel a Channel Points Prediction. Active Predictions can be updated to be “locked,” “resolved,” or “canceled.” 
        /// Locked Predictions can be updated to be “resolved” or “canceled.”
        /// <para>Required scope:</para>
        /// channel:manage:predictions
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="post">PostEndPrediction</param>
        /// <param name="optional">OptionalEndPrediction</param>
        /// <returns></returns>
        public ResponseEndPredictionData EndPrediction(PostEndPrediction post, OptionalEndPrediction optional = null)
        {

            ResponseEndPredictionData result = null;

            string url = BaseURL + URLext.Predictions;

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseEndPredictionData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets all scheduled broadcasts or specific scheduled broadcasts from a channel’s stream schedule. 
        /// Scheduled broadcasts are defined as “stream segments” in the API.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetChannelStreamSchedule</param>
        /// <param name="optional">OptionalGetChannelStreamSchedule</param>
        /// <returns></returns>
        public ResponseGetChannelStreamScheduleData GetChannelStreamSchedule(RequiredGetChannelStreamSchedule required, OptionalGetChannelStreamSchedule optional = null)
        {
            ResponseGetChannelStreamScheduleData result = null;

            string url = BaseURL + URLext.ChannelStreamSchedule;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChannelStreamScheduleData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets all scheduled broadcasts from a channel’s stream schedule as an iCalendar.
        /// </summary>
        /// <param name="required">RequiredGetChanneliCalendar</param>
        /// <returns></returns>
        public string GetChanneliCalendar(RequiredGetChanneliCalendar required)
        {
            string result = null;

            string url = BaseURL + URLext.ChanneliCalendar;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = download.Result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Update the settings for a channel’s stream schedule. This can be used for setting vacation details.
        /// <para>Required scope:</para>
        /// channel:manage:schedule
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredUpdateChannelStreamSchedule</param>
        /// <param name="optional">OptionalUpdateChannelStreamSchedule</param>
        /// <returns></returns>
        public bool UpdateChannelStreamSchedule(RequiredUpdateChannelStreamSchedule required, OptionalUpdateChannelStreamSchedule optional = null)
        {

            bool result = false;

            string url = BaseURL + URLext.ChannelStreamScheduleSettings;

            string dataString = "";

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Create a single scheduled broadcast or a recurring scheduled broadcast for a channel’s stream schedule.
        /// <para>Required scope:</para>
        /// channel:manage:schedule
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredCreateChannelStreamScheduleSegment</param>
        /// <param name="post">RequiredCreateChannelStreamScheduleSegment</param>
        /// <param name="optional">OptionalCreateChannelStreamScheduleSegment</param>
        /// <returns></returns>
        public ResponseCreateChannelStreamScheduleSegmentData CreateChannelStreamScheduleSegment(RequiredCreateChannelStreamScheduleSegment required, PostCreateChannelStreamScheduleSegment post, OptionalCreateChannelStreamScheduleSegment optional = null)
        {

            ResponseCreateChannelStreamScheduleSegmentData result = null;

            string url = BaseURL + URLext.ChannelStreamScheduleSegment;

            url += required.GetString();

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateChannelStreamScheduleSegmentData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Update a single scheduled broadcast or a recurring scheduled broadcast for a channel’s stream schedule.
        /// <para>Required scope:</para>
        /// channel:manage:schedule
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredUpdateChannelStreamScheduleSegment</param>
        /// <param name="optional">OptionalUpdateChannelStreamScheduleSegment</param>
        /// <returns></returns>
        public ResponseUpdateChannelStreamScheduleSegmentData UpdateChannelStreamScheduleSegment(RequiredUpdateChannelStreamScheduleSegment required, OptionalUpdateChannelStreamScheduleSegment optional = null)
        {

            ResponseUpdateChannelStreamScheduleSegmentData result = null;

            string url = BaseURL + URLext.ChannelStreamScheduleSegment;

            url += required.GetString();

            string dataString = "";

            if (optional != null)
                dataString += optional.GetDataString();

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PATCHRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateChannelStreamScheduleSegmentData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Delete a single scheduled broadcast or a recurring scheduled broadcast for a channel’s stream schedule.
        /// <para>Required scope:</para>
        /// channel:manage:schedule
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredDeleteChannelStreamScheduleSegment</param>
        /// <returns></returns>
        public bool DeleteChannelStreamScheduleSegment(RequiredDeleteChannelStreamScheduleSegment required)
        {

            bool result = false;

            string url = BaseURL + URLext.ChannelStreamScheduleSegment;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns a list of games or categories that match the query via name either entirely or partially.
        /// <para>OAuth or App Access Token required</para>
        /// </summary>
        /// <param name="required">RequiredSearchCategories</param>
        /// <param name="optional">OptionalSearchCategories</param>
        /// <returns></returns>
        public ResponseSearchCategoriesData SearchCategories(RequiredSearchCategories required, OptionalSearchCategories optional = null)
        {
            ResponseSearchCategoriesData result = null;

            string url = BaseURL + URLext.SearchCategories;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseSearchCategoriesData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Returns a list of channels (users who have streamed within the past 6 months) that match the query via channel name or description either entirely or partially. 
        /// Results include both live and offline channels. Online channels will have additional metadata.
        /// <para>OAuth or App Access Token required</para>
        /// </summary>
        /// <param name="required">RequiredSearchChannels</param>
        /// <param name="optional">OptionalSearchChannels</param>
        /// <returns></returns>
        public ResponseSearchChannelsData SearchChannels(RequiredSearchChannels required, OptionalSearchChannels optional = null)
        {
            ResponseSearchChannelsData result = null;

            string url = BaseURL + URLext.SearchChannels;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseSearchChannelsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the Soundtrack track that the broadcaster is playing.
        /// <para>Requires an App access token or User access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetSoundtrackCurrentTrack</param>
        /// <returns></returns>
        public ResponseGetSoundtrackCurrentTrackData GetSoundtrackCurrentTrack(RequiredGetSoundtrackCurrentTrack required)
        {
            ResponseGetSoundtrackCurrentTrackData result = null;

            string url = BaseURL + URLext.SoundtrackCurrentTrack;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetSoundtrackCurrentTrackData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a Soundtrack playlist, which includes its list of track
        /// <para>Requires an App access token or User access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetSoundtrackPlaylist</param>
        /// <returns></returns>
        public ResponseGetSoundtrackPlaylistData GetSoundtrackPlaylist(RequiredGetSoundtrackPlaylist required)
        {
            ResponseGetSoundtrackPlaylistData result = null;

            string url = BaseURL + URLext.SoundtrackPlaylist;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetSoundtrackPlaylistData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the channel stream key for a user.
        /// <para>Required scope:</para>
        /// channel:read:stream_key
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredGetStreamKey</param>
        /// <returns></returns>
        public ResponseGetStreamKeyData GetStreamKey(RequiredGetStreamKey required)
        {
            ResponseGetStreamKeyData result = null;

            string url = BaseURL + URLext.StreamKey;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetStreamKeyData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about active streams. Streams are returned sorted by number of current viewers, in descending order.
        /// Across multiple pages of results, there may be duplicate or missing streams, as viewers join and leave streams.
        /// <para>OAuth or App Access Token required</para>
        /// </summary>
        /// <param name="optional">OptionalGetStreams</param>
        /// <returns></returns>
        public ResponseGetStreamsData GetStreams(OptionalGetStreams optional = null)
        {
            ResponseGetStreamsData result = null;

            string url = BaseURL + URLext.Streams;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetStreamsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about active streams belonging to channels that the authenticated user follows. 
        /// Streams are returned sorted by number of current viewers, in descending order. 
        /// Across multiple pages of results, there may be duplicate or missing streams, as viewers join and leave streams.
        /// <para>Required scope:</para>
        /// user:read:follows
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="required">RequiredGetFollowedStreams</param>
        /// <param name="optional">OptionalGetFollowedStreams</param>
        /// <returns></returns>
        public ResponseGetFollowedStreamsData GetFollowedStreams(RequiredGetFollowedStreams required, OptionalGetFollowedStreams optional = null)
        {
            ResponseGetFollowedStreamsData result = null;

            string url = BaseURL + URLext.FollowedStreams;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetFollowedStreamsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Creates a marker in the stream of a user specified by user ID. 
        /// A marker is an arbitrary point in a stream that the broadcaster wants to mark; e.g., to easily return to later. 
        /// The marker is created at the current timestamp in the live broadcast when the request is processed. 
        /// Markers can be created by the stream owner or editors. 
        /// The user creating the marker is identified by a Bearer token.
        /// <para>Required scope:</para>
        /// channel:manage:broadcast
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="post">PostCreateStreamMarker</param>
        /// <param name="optional">OptionalCreateStreamMarker</param>
        /// <returns></returns>
        public ResponseCreateStreamMarkerData CreateStreamMarker(PostCreateStreamMarker post, OptionalCreateStreamMarker optional = null)
        {

            ResponseCreateStreamMarkerData result = null;

            string url = BaseURL + URLext.StreamMarker;

            string dataString = post.GetDataString();

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.POSTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCreateStreamMarkerData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of markers for either a specified user’s most recent stream or a specified VOD/video (stream), ordered by recency.
        /// A marker is an arbitrary point in a stream that the broadcaster wants to mark; e.g., to easily return to later. 
        /// The only markers returned are those created by the user identified by the Bearer token.
        /// <para>Required scope:</para>
        /// user:read:broadcast
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="required">RequiredGetStreamMarkers</param>
        /// <param name="optional">OptionalGetStreamMarkers</param>
        /// <returns></returns>
        public ResponseGetStreamMarkersData GetStreamMarkers(RequiredGetStreamMarkers required, OptionalGetStreamMarkers optional = null)
        {
            ResponseGetStreamMarkersData result = null;

            string url = BaseURL + URLext.StreamMarker;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetStreamMarkersData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of users that subscribe to the specified broadcaster.
        /// <para>Required scope:</para>
        /// channel:read:subscriptions
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="required">RequiredGetBroadcasterSubscriptions</param>
        /// <param name="optional">OptionalGetBroadcasterSubscriptions</param>
        /// <returns></returns>
        public ResponseGetBroadcasterSubscriptionsData GetBroadcasterSubscriptions(RequiredGetBroadcasterSubscriptions required, OptionalGetBroadcasterSubscriptions optional = null)
        {
            ResponseGetBroadcasterSubscriptionsData result = null;

            string url = BaseURL + URLext.BroadcasterSubscriptions;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetBroadcasterSubscriptionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Checks if a specific user (user_id) is subscribed to a specific channel (broadcaster_id).
        /// <para>Required scope:</para>
        /// user:read:subscriptions
        /// <para>App access or User access token</para>
        /// </summary>
        /// <param name="required">RequiredCheckUserSubscription</param>
        /// <returns></returns>
        public ResponseCheckUserSubscriptionData CheckUserSubscription(RequiredCheckUserSubscription required)
        {
            ResponseCheckUserSubscriptionData result = null;

            string url = BaseURL + URLext.UserSubscription;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseCheckUserSubscriptionData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the list of all stream tags that Twitch defines. You can also filter the list by one or more tag IDs.
        /// <para>Requires an application OAuth access token.</para>
        /// </summary>
        /// <param name="optional">OptionalGetAllStreamTags</param>
        /// <returns></returns>
        public ResponseGetAllStreamTagsData GetAllStreamTags(OptionalGetAllStreamTags optional = null)
        {
            ResponseGetAllStreamTagsData result = null;

            string url = BaseURL + URLext.AllStreamTags;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetAllStreamTagsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets the list of stream tags that are set on the specified channel.
        /// <para>Requires an application OAuth access token.</para>
        /// </summary>
        /// <param name="required">RequiredGetStreamTags</param>
        /// <returns></returns>
        public ResponseGetAllStreamTagsData GetStreamTags(RequiredGetStreamTags required)
        {
            ResponseGetAllStreamTagsData result = null;

            string url = BaseURL + URLext.StreamTags;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetAllStreamTagsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Applies one or more tags to the specified channel, overwriting any existing tags. 
        /// If the request does not specify tags, all existing tags are removed from the channel.
        /// <para>Required scope:</para>
        /// channel:manage:broadcast
        /// <para>Requires a user OAuth access token</para>
        /// </summary>
        /// <param name="required">RequiredReplaceStreamTags</param>
        /// <param name="optional">OptionalReplaceStreamTags</param>
        /// <returns></returns>
        public bool ReplaceStreamTags(RequiredReplaceStreamTags required, OptionalReplaceStreamTags optional = null)
        {

            bool result = false;

            string url = BaseURL + URLext.StreamTags;
            url += required.GetString();

            string dataString = "";

            if (optional != null)
                dataString += optional.GetDataString(true);

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Retrieves a list of Twitch Teams of which the specified channel/broadcaster is a member.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetChannelTeams</param>
        /// <returns></returns>
        public ResponseGetChannelTeamsData GetChannelTeams(RequiredGetChannelTeams required)
        {
            ResponseGetChannelTeamsData result = null;

            string url = BaseURL + URLext.ChannelTeams;

            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetChannelTeamsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information for a specific Twitch Team.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="optional">OptionalGetTeams</param>
        /// <returns></returns>
        public ResponseGetTeamsData GetTeams(OptionalGetTeams optional = null)
        {
            ResponseGetTeamsData result = null;

            string url = BaseURL + URLext.Teams;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetTeamsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about one or more specified Twitch users. Users are identified by optional user IDs and/or login name.
        /// If neither a user ID nor a login name is specified, the user is looked up by Bearer token.
        /// <para>Required scope:</para>
        /// user:read:email
        /// <para>OAuth or App Access Token required.</para>
        /// </summary>
        /// <param name="optional">OptionalGetTeams</param>
        /// <returns></returns>
        public ResponseGetUsersData GetUsers(OptionalGetUsers optional = null)
        {
            ResponseGetUsersData result = null;

            string url = BaseURL + URLext.Users;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUsersData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the description of a user specified by the bearer token. 
        /// Note that the description parameter is optional should other updatable parameters become available in the future. 
        /// If the description parameter is not provided, no update will occur and the current user data is returned.
        /// <para>Required scope:</para>
        /// user:edit
        /// <para>OAuth token required</para>
        /// </summary>
        /// <param name="optional">OptionalUpdateUser</param>
        /// <returns></returns>
        public ResponseUpdateUserData UpdateUser(OptionalUpdateUser optional = null)
        {

            ResponseUpdateUserData result = null;

            string url = BaseURL + URLext.Users;

            if (optional != null)
                url += optional.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseUpdateUserData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information on follow relationships between two Twitch users. 
        /// This can return information like “who is qotrok following,” “who is following 
        /// qotrok,” or “is user X following user Y.” Information returned is sorted in order, most recent follow first.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="optional">OptionalGetUsersFollows</param>
        /// <returns></returns>
        public ResponseGetUsersFollowsData GetUsersFollows(OptionalGetUsersFollows optional = null)
        {
            ResponseGetUsersFollowsData result = null;

            string url = BaseURL + URLext.UsersFollows;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUsersFollowsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a specified user’s block list. The list is sorted by when the block occurred in descending order (i.e. most recent block first).
        /// <para>Required scope:</para>
        /// user:read:blocked_users
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="required">RequiredGetUserBlockList</param>
        /// <param name="optional">OptionalGetUserBlockList</param>
        /// <returns></returns>
        public ResponseGetUserBlockListData GetUserBlockList(RequiredGetUserBlockList required, OptionalGetUserBlockList optional = null)
        {
            ResponseGetUserBlockListData result = null;

            string url = BaseURL + URLext.UserBlockList;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUserBlockListData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Blocks the specified user on behalf of the authenticated user.
        /// <para>Required scope:</para>
        /// user:manage:blocked_users
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="required">RequiredBlockUser</param>
        /// <param name="optional">OptionalBlockUser</param>
        /// <returns></returns>
        public bool BlockUser(RequiredBlockUser required, OptionalBlockUser optional = null)
        {

            bool result = false;

            string url = BaseURL + URLext.BlockedTerms;

            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.PUTRequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Unblocks the specified user on behalf of the authenticated user.
        /// <para>Required scope:</para>
        /// user:manage:blocked_users
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="required"></param>
        /// <returns></returns>
        public bool UnblockUser(RequiredUnblockUser required)
        {

            bool result = false;

            string url = BaseURL + URLext.BlockedTerms;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    var holder = download.Result;
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = false;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets a list of all extensions (both active and inactive) for a specified user, identified by a Bearer token.
        /// <para>Required scope:</para>
        /// user:read:broadcast
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <returns></returns>
        public ResponseGetUserExtensionsData GetUserExtensions()
        {
            ResponseGetUserExtensionsData result = null;

            string url = BaseURL + URLext.UserExtensions;

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUserExtensionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets information about active extensions installed by a specified user, identified by a user ID or Bearer token.
        /// <para>Required scope:</para>
        /// user:read:broadcast or user:edit:broadcast
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <param name="optional">OptionalGetUserActiveExtensions</param>
        /// <returns></returns>
        public ResponseGetUserActiveExtensionsData GetUserActiveExtensions(OptionalGetUserActiveExtensions optional = null)
        {
            ResponseGetUserActiveExtensionsData result = null;

            string url = BaseURL + URLext.UserExtensions;

            if (optional != null)
                url += optional.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUserActiveExtensionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Updates the activation state, extension ID, and/or version number of installed extensions for a specified user, 
        /// identified by a Bearer token. If you try to activate a given extension under multiple extension types,
        /// the last write wins (and there is no guarantee of write order).
        /// <para>Required scope:</para>
        /// user:edit:broadcast
        /// <para>OAuth user token required</para>
        /// </summary>
        /// <returns></returns>
        public bool UpdateUserExtensions()
        {
            return false;
        }

        /// <summary>
        /// Gets video information by one or more video IDs, user ID, or game ID. For lookup by user or game, several filters are available that can be specified as query parameters.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetVideosID</param>
        /// <param name="optional">OptionalGetVideos</param>
        /// <returns></returns>
        public ResponseGetUserActiveExtensionsData GetVideos(RequiredGetVideosID required)
        {
            ResponseGetUserActiveExtensionsData result = null;

            string url = BaseURL + URLext.Videos;
            url += required.GetString();

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUserActiveExtensionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets video information by one or more video IDs, user ID, or game ID. For lookup by user or game, several filters are available that can be specified as query parameters.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetVideosUSER</param>
        /// <param name="optional">OptionalGetVideos</param>
        /// <returns></returns>
        public ResponseGetUserActiveExtensionsData GetVideos(RequiredGetVideosUSER required, OptionalGetVideos optional = null)
        {
            ResponseGetUserActiveExtensionsData result = null;

            string url = BaseURL + URLext.Videos;
            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetUserActiveExtensionsData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Gets video information by one or more video IDs, user ID, or game ID. For lookup by user or game, several filters are available that can be specified as query parameters.
        /// <para>User OAuth Token or App Access Token</para>
        /// </summary>
        /// <param name="required">RequiredGetVideosGAME</param>
        /// <param name="optional">OptionalGetVideos</param>
        /// <returns></returns>
        public ResponseGetVideosData GetVideos(RequiredGetVideosGAME required, OptionalGetVideos optional = null)
        {
            ResponseGetVideosData result = null;

            string url = BaseURL + URLext.Videos;
            url += required.GetString();

            if (optional != null)
                url += optional.GetString(true);

            var download = Functions.GETRequest(Token, ClientID, url, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseGetVideosData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// Deletes one or more videos. Videos are past broadcasts, Highlights, or uploads.
        /// <para>Required scope:</para>
        /// channel:manage:videos
        /// <para>User OAuth token</para>
        /// </summary>
        /// <param name="required">RequiredDeleteVideos</param>
        /// <returns></returns>
        public ResponseDeleteVideosData DeleteVideos(RequiredDeleteVideos required)
        {

            ResponseDeleteVideosData result = null;

            string url = BaseURL + URLext.Videos;

            url += required.GetString();

            string dataString = "";

            var dataRaw = JObject.Parse("{" + dataString + "}").ToString();

            var download = Functions.DELETERequest(Token, ClientID, url, dataRaw, tokenType);

            bool waiter = false;

            try
            {
                waiter = download.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<ResponseDeleteVideosData>(download.Result, Functions.settings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }
    }

}
