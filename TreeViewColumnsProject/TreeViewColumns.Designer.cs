namespace TreeViewColumnsProject
{
	partial class TreeViewColumns
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node12");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node13");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
			treeNode1,
			treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node11");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
			treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node14");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node15");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node16");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
			treeNode6,
			treeNode7,
			treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
			treeNode3,
			treeNode5,
			treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node17");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
			treeNode11});
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node7");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
			treeNode12,
			treeNode13});
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node8");
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node19");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node9", new System.Windows.Forms.TreeNode[] {
			treeNode16});
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node20");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
			treeNode18});
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
			treeNode15,
			treeNode17,
			treeNode19});
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node18");
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4= new System.Windows.Forms.ColumnHeader();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
            this.columnHeader4});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(800, 20);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView1_ColumnWidthChanged);
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tag";
			this.columnHeader1.Width = 130;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Length";
			this.columnHeader2.Width = 129;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Value";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 145;


            this.columnHeader4.Text = "Description";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 145;
			// 
			// treeView1
			// 
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.CheckBoxes = true;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
			this.treeView1.HideSelection = false;
			this.treeView1.Location = new System.Drawing.Point(0, 20);
			this.treeView1.Name = "treeView1";
		
            this.treeView1.Size = new System.Drawing.Size(438, 164);
			this.treeView1.TabIndex = 2;
			this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
			this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
			// 
			// TreeViewColumns
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.listView1);
			this.Name = "TreeViewColumns";
			this.Size = new System.Drawing.Size(438, 184);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TreeView treeView1;
	}
}
