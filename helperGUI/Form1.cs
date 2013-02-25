using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParserLib.SMS;
using ParserLib;
using ParserLib.Util;

namespace helperGUI
{
    public partial class Form1 : Form
    {
        Envelope env;
        public Form1()
        {
            InitializeComponent();
            env = new Envelope();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //env.parseEnvelope(SourceTextBox.Text);
            //DestinationTextBox.SelectionTabs = new int[] { 10, 10, 5 };

            //TreeNode mainNode = new TreeNode(env.Tag);
            //string[] mainNodeContent = new string[] {env.Length.ToString(), env.Value,env.Description};
            //mainNode.Tag = mainNodeContent;
            //treeViewColumns1.TreeView.Nodes.Clear();
            //treeViewColumns1.TreeView.Nodes.AddRange(new TreeNode[] { mainNode });

            //TreeNode last= null;
            //foreach (TLV conten in env.Contents)
            //{
            //    DestinationTextBox.Text += "\n" + conten.Tag + "\t " + Conversion_BER_TLV.ConvertFromInt(conten.Length) + "\t " + conten.Value;
            //    TreeNode TN = new TreeNode(conten.Tag);
            //    string[] TNContent = new string[] { conten.Length.ToString(), conten.Value ,conten.Description};
            //    TN.Tag = TNContent;
            //    mainNode.Nodes.Add(TN);
            //    last = TN;
            //}
            TLV data = TLV.parse(SourceTextBox.Text);
        }

    }
}
