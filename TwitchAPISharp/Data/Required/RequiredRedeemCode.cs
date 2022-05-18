using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredRedeemCode : OptionSet<RequiredRedeemCode>
    {
        public List<string> code { get; internal set; }
        public int user_id { get; internal set; }

        /// <summary>
        /// RequiredRedeemCode
        /// </summary>
        /// <param name="code">The redemption code to redeem. To redeem multiple codes, include this parameter for each redemption code. For example, code=1234&code=5678. You may specify a maximum of 20 codes.</param>
        /// <param name="user_id">The ID of the user that owns the redemption code to redeem.</param>
        public RequiredRedeemCode(List<string> code, int user_id)
        {
            this.code = code;
            this.user_id = user_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
