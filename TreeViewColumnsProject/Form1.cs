using System;
using System.Windows.Forms;

namespace TreeViewColumnsProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            //TreeNode treeNode = new TreeNode("test");
            //treeNode.Tag = new string[] { "col1", "col2" };

            //// Some random node
            //this.treeViewColumns1.TreeView.Nodes[0].Nodes[0].Nodes.Add(treeNode);

            //this.treeViewColumns1.TreeView.SelectedNode = treeNode;


            var nore2 = new TreeNode("Tag loh");
            string[] list = new string[] { "Length", "Value" };
            nore2.Tag = list;
            var nore1 = new TreeNode("ola");
            var nore = new TreeNode("ola", new TreeNode[] { nore2, nore1 });
            this.treeViewColumns1.TreeView.Nodes.AddRange((new System.Windows.Forms.TreeNode[] {nore}));
		}
	}
}