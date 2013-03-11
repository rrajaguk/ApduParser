using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParserLib;
using ParserLib.Util;

namespace TreeViewColumnsProject
{
    public class DataConverter
    {

        public static TreeNode fromTLV(TLV data)
        {
            TreeNode result = new TreeNode(data.Tag);
            result.Name = data.Tag;
            // put the Length, Value, Description
            string[] content = { Conversion_BER_TLV.ConvertFromInt(data.Length), data.Value, data.Description };
            result.Tag = content;
            
            //traverse each child
            if (data.child!= null)
            {
                foreach(var child in data.child){
                    result.Nodes.Add(DataConverter.fromTLV(child));
                }
            }
            return result;
        }
    }
}
