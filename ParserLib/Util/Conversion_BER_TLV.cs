using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.Util
{
    public class Conversion_BER_TLV
    {
        /// <summary>
        /// Extract  Length part from a TLV string
        /// </summary>
        /// <param name="value">string contains the TLV</param>
        /// <param name="startingIndex">starting index of the length</param>
        /// <returns>Length in Integer</returns>
        public static int ConvertFromString(string value,ref int startingIndex)
        {
            int result = System.Convert.ToInt32(
                System.Convert.ToByte(
                    value.Substring(startingIndex, 2),
                    16));
            startingIndex += 2;
            int hexToTake = 0;
            if (result > 128)
            {
                hexToTake = (result- 128) * 2;
                result = 0;
            }
                //startingIndex+= 2;
                for (int i = 2; i <= hexToTake; i += 2)
                {
                    result+= System.Convert.ToInt32(
                        System.Convert.ToByte(value.Substring(startingIndex, 2), 16))
                        * (int)Math.Pow(16, (hexToTake - i));
                    startingIndex+= 2;
                }
            
            return result;
        }

        public static string ConvertFromInt(int value)
        {
            var res = string.Format("{0:X}", value);
            //padd with 0
            if (res.Length % 2 > 0)
            {
                res = "0" + res;
            }

            //pad with BER
            if (value > 127 && res.Length == 2)
            {
                res = "81" + res;
            }
            else if (res.Length > 2)
            {
                int temp = 128;
                temp += (res.Length/2);
                res = string.Format("{0:X}", temp) + res;

            }
            return res;
        }

   
    }
}
