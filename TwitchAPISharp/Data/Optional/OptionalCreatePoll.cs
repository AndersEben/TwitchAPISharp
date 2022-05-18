using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Optional
{
    public class OptionalCreatePoll : OptionSet<OptionalCreatePoll>
    {
        /// <summary>
        /// Indicates if Bits can be used for voting. Default: false
        /// </summary>
        public bool bits_voting_enabled = false;
        /// <summary>
        /// Number of Bits required to vote once with Bits. Minimum: 0. Maximum: 10000.
        /// </summary>
        public int bits_per_vote = 0;
        /// <summary>
        /// Indicates if Channel Points can be used for voting. Default: false
        /// </summary>
        public bool channel_points_voting_enabled = false;
        /// <summary>
        /// Number of Channel Points required to vote once with Channel Points. Minimum: 0. Maximum: 1000000.
        /// </summary>
        public int channel_points_per_vote = 0;
    }
}
