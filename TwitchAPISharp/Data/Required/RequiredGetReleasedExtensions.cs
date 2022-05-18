﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.Required
{
    public class RequiredGetReleasedExtensions : OptionSet<RequiredGetReleasedExtensions>
    {
        public string extension_id { get; internal set; }

        /// <summary>
        /// RequiredGetReleasedExtensions
        /// </summary>
        /// <param name="extension_id">ID of the Extension.</param>
        public RequiredGetReleasedExtensions(string extension_id)
        {
            this.extension_id = extension_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
