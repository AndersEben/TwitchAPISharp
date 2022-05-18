using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Data.JsonPost
{
    public class PostUpdateExtensionBitsProduct : OptionSet<PostUpdateExtensionBitsProduct>
    {
        public string sku { get; internal set; }
        public PostCost cost { get; internal set; }
        public string display_name { get; internal set; }

        /// <summary>
        /// PostUpdateExtensionBitsProduct
        /// </summary>
        /// <param name="sku">SKU of the Bits product. This must be unique across all products that belong to an Extension. The SKU cannot be changed after saving. Maximum: 255 characters, no white spaces.</param>
        /// <param name="cost">Object containing cost information.</param>
        /// <param name="display_name">Name of the product to be displayed in the Extension. Maximum: 255 characters.</param>
        public PostUpdateExtensionBitsProduct(string sku, PostCost cost, string display_name)
        {
            this.sku = sku;
            this.cost = cost;
            this.display_name = display_name;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
