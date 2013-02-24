using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.SMS
{
    public class TPDU : TLV
    {
        public Data_0340 data_0340 { get; set; }
        public TPDU(TLV val)
        {
            this.Tag = val.Tag;
            this.Length = val.Length;
            this.Value = val.Value;
            data_0340 = new Data_0340(val.Value);
        }
    }
}
