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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataInputGroup = new System.Windows.Forms.GroupBox();
            this.manualInput = new System.Windows.Forms.Button();
            this.LoadCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataContainer = new System.Windows.Forms.GroupBox();
            this.editLittles = new System.Windows.Forms.Button();
            this.editBigs = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.export = new System.Windows.Forms.Button();
            this.match = new System.Windows.Forms.Button();
            this.viewMatches = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.dataInputGroup.SuspendLayout();
            this.dataContainer.SuspendLayout();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // littleBox
            // 
            this.littleBox.Location = new System.Drawing.Point(193, 27);
            this.littleBox.Multiline = true;
            this.littleBox.Name = "littleBox";
            this.littleBox.ReadOnly = true;
            this.littleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.littleBox.Size = new System.Drawing.Size(175, 228);
            this.littleBox.TabIndex = 4;
            // 
            // bigsBox
            // 
            this.bigsBox.Location = new System.Drawing.Point(6, 27);
            this.bigsBox.Multiline = true;
            this.bigsBox.Name = "bigsBox";
            this.bigsBox.ReadOnly = true;
            this.bigsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bigsBox.Size = new System.Drawing.Size(175, 228);
            this.bigsBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bigs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 0);
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
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
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
            this.bigsToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bigsToolStripMenuItem.Text = "Bigs";
            this.bigsToolStripMenuItem.Click += new System.EventHandler(this.bigsToolStripMenuItem_Click);
            // 
            // littlesToolStripMenuItem
            // 
            this.littlesToolStripMenuItem.Name = "littlesToolStripMenuItem";
            this.littlesToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.littlesToolStripMenuItem.Text = "Littles";
            this.littlesToolStripMenuItem.Click += new System.EventHandler(this.littlesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // dataInputGroup
            // 
            this.dataInputGroup.Controls.Add(this.manualInput);
            this.dataInputGroup.Controls.Add(this.LoadCSV);
            this.dataInputGroup.Controls.Add(this.label3);
            this.dataInputGroup.Location = new System.Drawing.Point(13, 28);
            this.dataInputGroup.Name = "dataInputGroup";
            this.dataInputGroup.Size = new System.Drawing.Size(374, 55);
            this.dataInputGroup.TabIndex = 9;
            this.dataInputGroup.TabStop = false;
            // 
            // manualInput
            // 
            this.manualInput.Location = new System.Drawing.Point(277, 19);
            this.manualInput.Name = "manualInput";
            this.manualInput.Size = new System.Drawing.Size(91, 23);
            this.manualInput.TabIndex = 2;
            this.manualInput.Text = "Manual Input";
            this.manualInput.UseVisualStyleBackColor = true;
            this.manualInput.Click += new System.EventHandler(this.manualInput_Click);
            // 
            // LoadCSV
            // 
            this.LoadCSV.Location = new System.Drawing.Point(6, 19);
            this.LoadCSV.Name = "LoadCSV";
            this.LoadCSV.Size = new System.Drawing.Size(91, 23);
            this.LoadCSV.TabIndex = 1;
            this.LoadCSV.Text = "Load CSV File";
            this.LoadCSV.UseVisualStyleBackColor = true;
            this.LoadCSV.Click += new System.EventHandler(this.LoadCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Input";
            // 
            // dataContainer
            // 
            this.dataContainer.Controls.Add(this.editLittles);
            this.dataContainer.Controls.Add(this.editBigs);
            this.dataContainer.Controls.Add(this.label1);
            this.dataContainer.Controls.Add(this.littleBox);
            this.dataContainer.Controls.Add(this.bigsBox);
            this.dataContainer.Controls.Add(this.label2);
            this.dataContainer.Location = new System.Drawing.Point(13, 90);
            this.dataContainer.Name = "dataContainer";
            this.dataContainer.Size = new System.Drawing.Size(374, 292);
            this.dataContainer.TabIndex = 10;
            this.dataContainer.TabStop = false;
            // 
            // editLittles
            // 
            this.editLittles.Location = new System.Drawing.Point(241, 261);
            this.editLittles.Name = "editLittles";
            this.editLittles.Size = new System.Drawing.Size(75, 23);
            this.editLittles.TabIndex = 9;
            this.editLittles.Text = "Edit";
            this.editLittles.UseVisualStyleBackColor = true;
            this.editLittles.Click += new System.EventHandler(this.editLittles_Click);
            // 
            // editBigs
            // 
            this.editBigs.Location = new System.Drawing.Point(57, 261);
            this.editBigs.Name = "editBigs";
            this.editBigs.Size = new System.Drawing.Size(75, 23);
            this.editBigs.TabIndex = 8;
            this.editBigs.Text = "Edit";
            this.editBigs.UseVisualStyleBackColor = true;
            this.editBigs.Click += new System.EventHandler(this.editBigs_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.viewMatches);
            this.resultsBox.Controls.Add(this.export);
            this.resultsBox.Controls.Add(this.match);
            this.resultsBox.Location = new System.Drawing.Point(13, 388);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(374, 38);
            this.resultsBox.TabIndex = 11;
            this.resultsBox.TabStop = false;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(260, 9);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(108, 23);
            this.export.TabIndex = 1;
            this.export.Text = "Export Matches";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // match
            // 
            this.match.Location = new System.Drawing.Point(6, 9);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(108, 23);
            this.match.TabIndex = 0;
            this.match.Text = "Compute Matches";
            this.match.UseVisualStyleBackColor = true;
            this.match.Click += new System.EventHandler(this.match_Click);
            // 
            // viewMatches
            // 
            this.viewMatches.Location = new System.Drawing.Point(134, 9);
            this.viewMatches.Name = "viewMatches";
            this.viewMatches.Size = new System.Drawing.Size(103, 23);
            this.viewMatches.TabIndex = 2;
            this.viewMatches.Text = "View Matches";
            this.viewMatches.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 438);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.dataInputGroup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Big Little Matching";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dataInputGroup.ResumeLayout(false);
            this.dataInputGroup.PerformLayout();
            this.dataContainer.ResumeLayout(false);
            this.dataContainer.PerformLayout();
            this.resultsBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox dataInputGroup;
        private System.Windows.Forms.Button manualInput;
        private System.Windows.Forms.Button LoadCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox dataContainer;
        private System.Windows.Forms.Button editLittles;
        private System.Windows.Forms.Button editBigs;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button match;
        private System.Windows.Forms.Button viewMatches;
    }
}

