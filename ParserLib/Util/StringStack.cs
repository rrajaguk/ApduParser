using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class StringStack
    {
        public string OriginalString { get; private set; }
        private int offset;
        public StringStack(string val)
        {
            OriginalString = val;
            offset = 0;
        }
        public string getByte()
        {
            string temp = OriginalString.Substring(offset, 2);
            offset += 2;
            return temp;
        }
        public string getBytes(int length)
        {
            string temp = OriginalString.Substring(offset, length * 2);
            offset += length * 2;
            return temp;

        }
        public string getRemaining()
        {
            return OriginalString.Substring(offset);
        }

    }
}
