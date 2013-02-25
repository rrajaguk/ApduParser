namespace TreeViewColumnsProject
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeViewColumns1 = new TreeViewColumnsProject.TreeViewColumns();
			this.SuspendLayout();
			// 
			// treeViewColumns1
			// 
			this.treeViewColumns1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
			this.treeViewColumns1.Location = new System.Drawing.Point(8, 8);
			this.treeViewColumns1.Name = "treeViewColumns1";
			this.treeViewColumns1.Padding = new System.Windows.Forms.Padding(1);
			this.treeViewColumns1.Size = new System.Drawing.Size(438, 184);
			this.treeViewColumns1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 205);
			this.Controls.Add(this.treeViewColumns1);
			this.Name = "Form1";
			this.Text = "Example TreeViewColumns (lite)";
			this.ResumeLayout(false);

		}

		#endregion

		private TreeViewColumns treeViewColumns1;




	}
}

