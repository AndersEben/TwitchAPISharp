using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options
{
    /// <summary>
    /// Twitch TokenType formats
    /// </summary>
    public enum TokenType
    {
        Bearer
    }

    /// <summary>
    /// WebClient Post or Get Request
    /// </summary>
    public enum WebType
    {
        GET,
        POST,
        PATCH,
        DELETE
    }


    public enum StreamLanguage
    {
        en
    }

    public enum RedemptionStatus
    {
        FULFILLED,
        CANCELED
    }

    public enum DropsEntitlements
    {
        CLAIMED,
        FULFILLED
    }

    public enum EndPollStatus
    {
        TERMINATED,
        ARCHIVED
    }

    public enum EndPredictionStatus
    {
        RESOLVED,
        CANCELED,
        LOCKED
    }
}
