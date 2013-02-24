using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParserLib.Util;

namespace ParserLib
{
    public class APDU
    {

        public static List<TLV> Parse(string value)
        {
            List<TLV> result  = null;
            try
            {
                value = StringManipulator.removeSpace(value);
                result = new List<TLV>();
                TLV tlv;
                int marker = 0;
                while (marker < value.Length)
                {

                    //fill up the Tag
                    tlv = new TLV();
                    tlv.Tag = value.Substring(marker, 2);
                    marker += 2;

                    if (marker + 2 > value.Length)
                    {
                        marker += 2;
                        continue;
                    }
                    // ber-TLV processing 
                    tlv.Length = Conversion_BER_TLV.ConvertFromString(value, ref marker);

                    //fill up the value part
                    if (tlv.Length * 2 + marker > value.Length)
                    {
                        marker = value.Length + 1;
                        continue;
                    }

                    //if it's only TL without V then add the TLV immediately
                    if (tlv.Length < 1)
                    {
                        result.Add(tlv);
                        continue;
                    }

                    tlv.Value = value.Substring(marker, tlv.Length * 2);
                    marker += tlv.Length * 2;

                    result.Add(tlv);

                }
            }
            catch (Exception)
            {
                
            }

            return result;
        }
    }
}
