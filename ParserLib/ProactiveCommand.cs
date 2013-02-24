using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public  class ProactiveCommand
    {
        List<TLV> internalTLV;
        public void ParseAPDU(string val)
        {
            APDU apdu = new APDU();
            val = StringManipulator.removeSpace(val);
            internalTLV = APDU.Parse(val);
        }
    }
}
