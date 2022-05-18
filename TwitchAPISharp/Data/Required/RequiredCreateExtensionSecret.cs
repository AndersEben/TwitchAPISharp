﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredCreateExtensionSecret : OptionSet<RequiredCreateExtensionSecret>
    {
        public string extension_id { get; internal set; }

        /// <summary>
        /// RequiredCreateExtensionSecret
        /// </summary>
        /// <param name="extension_id">ID of the Extension to search for.</param>
        public RequiredCreateExtensionSecret(string extension_id)
        {
            this.extension_id = extension_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
