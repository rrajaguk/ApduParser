using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.SMS
{
    public class Data_0348
    {
        public string UDHL { get; set; }
        public string IEIa { get; set; }
        public string IEDa { get; set; }
        public string CPL { get; set; }

        public int CHL { get; set; }
        public string SPI { get; set; }
        public string Kic { get; set; }
        public string Kid { get; set; }
        public string TAR { get; set; }
        public string CNTR { get; set; }
        public string PCNTR { get; set; }
        public string RC_CC_DS { get; set; }

        public int TPUDL { get; set; }
        public string SecureData { get; set; }

        public Data_0348(string val){
            StringStack SS = new StringStack(val);
            TPUDL = Convert.ToInt32(Convert.ToByte(SS.getByte(),16));
            UDHL =SS.getByte();
            IEIa =SS.getByte();
            IEDa =SS.getByte();
            CPL = SS.getBytes(2);
            CHL = Convert.ToInt32(Convert.ToByte(SS.getByte(), 16));
            SPI = SS.getBytes(2);
            Kic  = SS.getByte();
            Kid = SS.getByte();
            TAR = SS.getBytes(3);
            CNTR = SS.getBytes(5);
            PCNTR = SS.getByte();

            if (CHL > 13)
            {
                RC_CC_DS = SS.getBytes(CHL - 13);
            }

            SecureData = SS.getRemaining();

        }

    }
}
