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
using TreeViewColumnsProject;

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
            treeViewColumns1.TreeView.Nodes.Clear();
            treeViewColumns1.TreeView.Nodes.AddRange(new TreeNode[] {DataConverter.fromTLV(TLV.parse(SourceTextBox.Text))});
        }

    }
}
