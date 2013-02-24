using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib.SMS
{
    public class TPDA
    {
        public int NumberOfNibble { get; set; }
        public string Address { get; set; }
        public string RealAddress { 
            get {
                StringBuilder res = new StringBuilder();
                for (int i = 0; i < Address.Length; i += 2)
                {
                    res.Append(Address[i + 1]);
                    if (Address[i] != 'F')
                    {
                        res.Append(Address[i]);
                    }
                }
                return res.ToString();
            } 
            set{
                RealAddress = value;
            } 
        }
        public string TON_NPI { get; set; }

        public string parse(string val)
        {
            NumberOfNibble = Int32.Parse(StringManipulator.getByte(val, 1));
            TON_NPI = StringManipulator.getByte(val, 2);
            int temp =( NumberOfNibble + 1 )/2 ;
            Address = StringManipulator.getBytes(val, 3, temp).ToUpper();
            return val.Substring((temp+2)*2);
        }
    }
}
