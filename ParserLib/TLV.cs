using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class TLV
    {
        public string Tag { get; set; }
        public int Length { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public List<TLV> child { get; private set; }
        public void parse()
        {

        }
        public void addChild(TLV val)
        {
            if (child == null)
            {
                child = new List<TLV>();
            }
            child.Add(val);
        }

        public static TLV parse(string testData)
        {
            TLV result = null;
            List<TLV> val =APDU.Parse(testData);
            if (val == null)
                return null;
            if (val.Count > 0)
            {
                result = val.First();
                List<TLV> childs = APDU.Parse(result.Value);
                if (childs!= null && childs.Count > 0)
                {
                    foreach (var child in childs)
                    {
                        TLV gg = TLV.parse(child.Value);
                        if (gg != null)
                        {
                            child.addChild(gg);
                        }
                        result.addChild(child);
                    }
                }
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}
