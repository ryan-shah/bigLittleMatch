namespace bigLittleMatch
{
    partial class mainForm
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
            this.littleBox = new System.Windows.Forms.TextBox();
            this.bigsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computeMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // littleBox
            // 
            this.littleBox.Location = new System.Drawing.Point(206, 51);
            this.littleBox.Multiline = true;
            this.littleBox.Name = "littleBox";
            this.littleBox.Size = new System.Drawing.Size(181, 379);
            this.littleBox.TabIndex = 4;
            // 
            // bigsBox
            // 
            this.bigsBox.Location = new System.Drawing.Point(12, 51);
            this.bigsBox.Multiline = true;
            this.bigsBox.Name = "bigsBox";
            this.bigsBox.Size = new System.Drawing.Size(181, 379);
            this.bigsBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bigs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Littles";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCSVToolStripMenuItem,
            this.manualInputToolStripMenuItem,
            this.computeMatchesToolStripMenuItem,
            this.exportDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCSVToolStripMenuItem
            // 
            this.openCSVToolStripMenuItem.Name = "openCSVToolStripMenuItem";
            this.openCSVToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openCSVToolStripMenuItem.Text = "Open CSV";
            this.openCSVToolStripMenuItem.Click += new System.EventHandler(this.openCSVToolStripMenuItem_Click);
            // 
            // manualInputToolStripMenuItem
            // 
            this.manualInputToolStripMenuItem.Name = "manualInputToolStripMenuItem";
            this.manualInputToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manualInputToolStripMenuItem.Text = "Manual Input";
            this.manualInputToolStripMenuItem.Click += new System.EventHandler(this.manualInputToolStripMenuItem_Click);
            // 
            // computeMatchesToolStripMenuItem
            // 
            this.computeMatchesToolStripMenuItem.Name = "computeMatchesToolStripMenuItem";
            this.computeMatchesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.computeMatchesToolStripMenuItem.Text = "Compute Matches";
            this.computeMatchesToolStripMenuItem.Click += new System.EventHandler(this.computeMatchesToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bigsToolStripMenuItem,
            this.littlesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bigsToolStripMenuItem
            // 
            this.bigsToolStripMenuItem.Name = "bigsToolStripMenuItem";
            this.bigsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bigsToolStripMenuItem.Text = "Bigs";
            this.bigsToolStripMenuItem.Click += new System.EventHandler(this.bigsToolStripMenuItem_Click);
            // 
            // littlesToolStripMenuItem
            // 
            this.littlesToolStripMenuItem.Name = "littlesToolStripMenuItem";
            this.littlesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.littlesToolStripMenuItem.Text = "Littles";
            this.littlesToolStripMenuItem.Click += new System.EventHandler(this.littlesToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigsBox);
            this.Controls.Add(this.littleBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Big Little Matching";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox littleBox;
        private System.Windows.Forms.TextBox bigsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computeMatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littlesToolStripMenuItem;
    }
}

