using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class StringManipulator
    {
        public static string removeSpace(string val)
        {
            return val.Replace(" ", "");
        }
        public static string getByte(string vall, int pos)
        {
            return vall.Substring((pos - 1) * 2, 2);
        }
        public static string getBytes(string vall, int pos,int length)
        {
            return vall.Substring((pos - 1) * 2, length* 2);
        }
    }

   
}
