using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options
{
    public class CommercialLength
    {
        public static readonly CommercialLength thirty = new CommercialLength(30);
        public static readonly CommercialLength sixty = new CommercialLength(60);
        public static readonly CommercialLength ninety = new CommercialLength(90);
        public static readonly CommercialLength onehundredandtwenty = new CommercialLength(120);
        public static readonly CommercialLength onehundredandfifty = new CommercialLength(150);
        public static readonly CommercialLength onehundredandeighty = new CommercialLength(180);
        private CommercialLength(int lenght)
        {
            this.length = length;
        }

        public int length { get; private set; }
    }
}
