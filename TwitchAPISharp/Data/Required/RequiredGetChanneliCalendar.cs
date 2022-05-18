using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetChanneliCalendar : OptionSet<RequiredGetChanneliCalendar>
    {
        public string broadcaster_id { get; internal set; }

        /// <summary>
        /// RequiredGetChanneliCalendar
        /// </summary>
        /// <param name="broadcaster_id">User ID of the broadcaster who owns the channel streaming schedule.</param>
        public RequiredGetChanneliCalendar(string broadcaster_id)
        {
            this.broadcaster_id = broadcaster_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
