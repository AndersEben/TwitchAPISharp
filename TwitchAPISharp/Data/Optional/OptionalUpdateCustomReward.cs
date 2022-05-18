using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalUpdateCustomReward : OptionSet<OptionalUpdateCustomReward>
    {
        /// <summary>
        /// The title of the reward.
        /// </summary>
        public string title = null;
        /// <summary>
        /// The prompt for the viewer when they are redeeming the reward.
        /// </summary>
        public string prompt = null;
        /// <summary>
        /// The cost of the reward.
        /// </summary>
        public int cost = 0;
        /// <summary>
        /// Custom background color for the reward as a hexadecimal value. Example: #00E5CB.
        /// </summary>
        public string background_color = null;
        /// <summary>
        /// Is the reward currently enabled, if false the reward won’t show up to viewers.
        /// </summary>
        public bool is_enabled = false;
        /// <summary>
        /// Does the user need to enter information when redeeming the reward.
        /// </summary>
        public bool is_user_input_required = false;
        /// <summary>
        /// Whether a maximum per stream is enabled. Required when any value of max_per_stream is included.
        /// </summary>
        public bool is_max_per_stream_enabled = false;
        /// <summary>
        /// The maximum number per stream if enabled. Required when any value of is_max_per_stream_enabled is included.
        /// </summary>
        public int max_per_stream = 0;
        /// <summary>
        /// Whether a maximum per user per stream is enabled. Required when any value of max_per_user_per_stream is included.
        /// </summary>
        public bool is_max_per_user_per_stream_enabled = false;
        /// <summary>
        /// The maximum number per user per stream if enabled. Required when any value of is_max_per_user_per_stream_enabled is included.
        /// </summary>
        public int max_per_user_per_stream = 0;
        /// <summary>
        /// Whether a cooldown is enabled. Required when any value of global_cooldown_seconds is included.
        /// </summary>
        public bool is_global_cooldown_enabled = false;
        /// <summary>
        /// The cooldown in seconds if enabled. Required when any value of is_global_cooldown_enabled is included.
        /// </summary>
        public int global_cooldown_seconds = 0;
        /// <summary>
        /// Is the reward currently paused, if true viewers cannot redeem.
        /// </summary>
        public bool is_paused = false;
        /// <summary>
        /// Should redemptions be set to FULFILLED status immediately when redeemed and skip the request queue instead of the normal UNFULFILLED status.
        /// </summary>
        public bool should_redemptions_skip_request_queue = false;
    }
}
