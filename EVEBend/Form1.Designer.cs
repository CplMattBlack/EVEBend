namespace EVEBend
{
    partial class FormMain
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
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExport = new System.Windows.Forms.Button();
            this.rtbPrices = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRetrieve = new System.Windows.Forms.Button();
            this.lblNews = new System.Windows.Forms.Label();
            this.lblEditSuccessful = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClear.Location = new System.Drawing.Point(163, 199);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.TabStop = false;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExport.Location = new System.Drawing.Point(244, 199);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(75, 23);
            this.cmdExport.TabIndex = 3;
            this.cmdExport.TabStop = false;
            this.cmdExport.Text = "EXPORT";
            this.cmdExport.UseVisualStyleBackColor = false;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // rtbPrices
            // 
            this.rtbPrices.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbPrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPrices.Location = new System.Drawing.Point(12, 55);
            this.rtbPrices.Name = "rtbPrices";
            this.rtbPrices.ReadOnly = true;
            this.rtbPrices.Size = new System.Drawing.Size(306, 138);
            this.rtbPrices.TabIndex = 1;
            this.rtbPrices.TabStop = false;
            this.rtbPrices.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelPathToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // excelPathToolStripMenuItem
            // 
            this.excelPathToolStripMenuItem.Name = "excelPathToolStripMenuItem";
            this.excelPathToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.excelPathToolStripMenuItem.Text = "Fuck You";
            this.excelPathToolStripMenuItem.Click += new System.EventHandler(this.excelPathToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmdRetrieve
            // 
            this.cmdRetrieve.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRetrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRetrieve.Location = new System.Drawing.Point(12, 26);
            this.cmdRetrieve.Name = "cmdRetrieve";
            this.cmdRetrieve.Size = new System.Drawing.Size(306, 23);
            this.cmdRetrieve.TabIndex = 0;
            this.cmdRetrieve.TabStop = false;
            this.cmdRetrieve.Text = "RETRIEVE INFO";
            this.cmdRetrieve.UseVisualStyleBackColor = false;
            this.cmdRetrieve.Click += new System.EventHandler(this.cmdRetrieve_Click);
            // 
            // lblNews
            // 
            this.lblNews.AutoSize = true;
            this.lblNews.Location = new System.Drawing.Point(9, 204);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(0, 13);
            this.lblNews.TabIndex = 6;
            // 
            // lblEditSuccessful
            // 
            this.lblEditSuccessful.AutoSize = true;
            this.lblEditSuccessful.Location = new System.Drawing.Point(9, 204);
            this.lblEditSuccessful.Name = "lblEditSuccessful";
            this.lblEditSuccessful.Size = new System.Drawing.Size(92, 13);
            this.lblEditSuccessful.TabIndex = 7;
            this.lblEditSuccessful.Text = "Export Successful";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.lblEditSuccessful);
            this.Controls.Add(this.lblNews);
            this.Controls.Add(this.cmdRetrieve);
            this.Controls.Add(this.rtbPrices);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVEBend";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.RichTextBox rtbPrices;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button cmdRetrieve;
        private System.Windows.Forms.Label lblNews;
        private System.Windows.Forms.Label lblEditSuccessful;
    }
}

