using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostCheckAutoModStatus : OptionSet<PostCheckAutoModStatus>
    {
        public string data { get; internal set; }

        /// <summary>
        /// PostCheckAutoModStatus
        /// </summary>
        /// <param name="data">Data Objekt</param>
        public PostCheckAutoModStatus(List<PostAutoModData> data)
        {
            this.data += "[";

            bool first = true;
            foreach (PostAutoModData ModData in data)
            {
                if(!first)
                    this.data += ModData.GetDataString(true);
                else
                {
                    this.data += ModData.GetDataString();
                    first = !first;
                }
            }

            this.data += "]";

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
