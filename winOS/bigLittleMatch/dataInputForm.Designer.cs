namespace bigLittleMatch
{
    partial class dataInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prefBox = new System.Windows.Forms.TextBox();
            this.addBigs = new System.Windows.Forms.Button();
            this.addLittles = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(123, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preferences:";
            // 
            // prefBox
            // 
            this.prefBox.Location = new System.Drawing.Point(15, 52);
            this.prefBox.Multiline = true;
            this.prefBox.Name = "prefBox";
            this.prefBox.Size = new System.Drawing.Size(164, 173);
            this.prefBox.TabIndex = 3;
            // 
            // addBigs
            // 
            this.addBigs.Location = new System.Drawing.Point(12, 227);
            this.addBigs.Name = "addBigs";
            this.addBigs.Size = new System.Drawing.Size(75, 23);
            this.addBigs.TabIndex = 4;
            this.addBigs.Text = "Add to Bigs";
            this.addBigs.UseVisualStyleBackColor = true;
            this.addBigs.Click += new System.EventHandler(this.addBigs_Click);
            // 
            // addLittles
            // 
            this.addLittles.Location = new System.Drawing.Point(93, 227);
            this.addLittles.Name = "addLittles";
            this.addLittles.Size = new System.Drawing.Size(86, 23);
            this.addLittles.TabIndex = 5;
            this.addLittles.Text = "Add to Littles";
            this.addLittles.UseVisualStyleBackColor = true;
            this.addLittles.Click += new System.EventHandler(this.addLittles_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(12, 256);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(167, 23);
            this.doneBtn.TabIndex = 6;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // dataInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 289);
            this.ControlBox = false;
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.addLittles);
            this.Controls.Add(this.addBigs);
            this.Controls.Add(this.prefBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "dataInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Data Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prefBox;
        private System.Windows.Forms.Button addBigs;
        private System.Windows.Forms.Button addLittles;
        private System.Windows.Forms.Button doneBtn;
    }
}