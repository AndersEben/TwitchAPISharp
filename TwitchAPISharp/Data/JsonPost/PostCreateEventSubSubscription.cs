using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;
using TwitchAPISharp.Options.Sub.SubOptional;
using TwitchAPISharp.Options.Sub.SubRequired;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCreateEventSubSubscription : OptionSet<PostCreateEventSubSubscription>
    {
        public string type { get; internal set; }
        public string version { get; internal set; }
        public string condition { get; internal set; }
        public string transport { get; internal set; }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="client_id">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_client client_id, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;
            this.condition = "{" + client_id.GetDataString() + "}";
            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="broadcaster_user_id">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_broadcaster broadcaster_user_id, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;
            this.condition = "{" + broadcaster_user_id.GetDataString() + "}";
            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="broadcaster_user_id">The parameter values that are specific to the specified subscription type.</param>        
        /// <param name="optional">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_client broadcaster_user_id, Optional_reward optional, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;

            this.condition = "{" + broadcaster_user_id.GetDataString();
            
            if(optional != null)
                this.condition += optional.GetDataString(true) + "}";
            else
                this.condition += "}";

            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="organization_id">The parameter values that are specific to the specified subscription type.</param>        
        /// <param name="optional">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_organization organization_id, Optional_organization optional, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;

            this.condition = "{" + organization_id.GetDataString();

            if (optional != null)
                this.condition += optional.GetDataString(true) + "}";
            else
                this.condition += "}";

            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="extension_client_id">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_extension extension_client_id, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;
            this.condition = "{" + extension_client_id.GetDataString() + "}";
            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>
        /// <param name="user_id">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, Required_user user_id, SubscriptionTransport transport)
        {
            this.type = type.ToString();
            this.version = version;
            this.condition = "{" + user_id.GetDataString() + "}";
            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// PostCreateEventSubSubscription
        /// </summary>
        /// <param name="type">The type of subscription to create. For a list of subscriptions you can create, see Subscription Types. Set type to the value in the Name column of the Subscription Types table.</param>
        /// <param name="version">The version of the subscription type used in this request. A subscription type could define one or more object definitions, so you need to specify which definition you’re using.</param>  
        /// <param name="optional">The parameter values that are specific to the specified subscription type.</param>
        /// <param name="transport">The transport details, such as the transport method and callback URL, that you want Twitch to use when sending you notifications.</param>
        public PostCreateEventSubSubscription(SubscriptionTypes type, string version, SubscriptionTransport transport, Optional_broadcaster optional = null)
        {
            this.type = type.ToString();
            this.version = version;

            if(optional != null)
                this.condition = "{" + optional.GetDataString() + "}";
            else
                this.condition = "{ }";

            this.transport = "{" + transport.GetDataString() + "}";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
