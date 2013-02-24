using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.SMS
{
    public class Envelope :TLV
    {

        public List<TLV> Contents;
        public Envelope()
        {
            Contents = new List<TLV>();
        }
        public void parseEnvelope(string val)
        {
            TLV mainTLV = APDU.Parse(val).First<TLV>();
            this.Tag = mainTLV.Tag;
            this.Length = mainTLV.Length;
            this.Value = mainTLV.Value;
            this.Description = "Envelope";
            Contents = APDU.Parse(mainTLV.Value);           

        }
    }
}
