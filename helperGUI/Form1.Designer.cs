namespace helperGUI
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
            this.SourceTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.RichTextBox();
            this.treeViewColumns1 = new TreeViewColumnsProject.TreeViewColumns();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(12, 29);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(343, 164);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Translate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(12, 211);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(343, 206);
            this.DestinationTextBox.TabIndex = 3;
            this.DestinationTextBox.Text = "";
            // 
            // treeViewColumns1
            // 
            this.treeViewColumns1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.treeViewColumns1.Location = new System.Drawing.Point(12, 464);
            this.treeViewColumns1.Name = "treeViewColumns1";
            this.treeViewColumns1.Padding = new System.Windows.Forms.Padding(1);
            this.treeViewColumns1.Size = new System.Drawing.Size(760, 184);
            this.treeViewColumns1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 809);
            this.Controls.Add(this.treeViewColumns1);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SourceTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SourceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox DestinationTextBox;
        private TreeViewColumnsProject.TreeViewColumns treeViewColumns1;
    }
}

