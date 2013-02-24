using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.SMS
{
    public class Data_0340
    {
        public string TP_MTI { get; set; }
        public string TP_MR{ get; set; }
        public TPDA TPOA{ get; set; }
        public string TP_PID{ get; set; }
        public string TP_DCS  { get; set; }
        public string TP_SCTS { get; set; }
        public string TP_UDL { get; set; }
        public Data_0348 UserData { get; set; }

        public Data_0340(string val)
        {
            StringStack SS = new StringStack(val);
            TP_MTI = SS.getByte();
            TPOA = new TPDA();
            val = TPOA.parse(SS.getRemaining());

            SS = new StringStack(val);
            TP_PID = SS.getByte();
            TP_DCS = SS.getByte();
            TP_SCTS = SS.getBytes(7);
            
            UserData = new Data_0348(SS.getRemaining());

        }
    }
}
