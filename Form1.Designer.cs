namespace Reminders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.next7DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.next14DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.next21DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.next28DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 37);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(563, 222);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.remindersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // remindersToolStripMenuItem
            // 
            this.remindersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.next7DaysToolStripMenuItem,
            this.next14DaysToolStripMenuItem,
            this.next21DaysToolStripMenuItem,
            this.next28DaysToolStripMenuItem});
            this.remindersToolStripMenuItem.Name = "remindersToolStripMenuItem";
            this.remindersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.remindersToolStripMenuItem.Text = "&Reminders";
            // 
            // next7DaysToolStripMenuItem
            // 
            this.next7DaysToolStripMenuItem.Name = "next7DaysToolStripMenuItem";
            this.next7DaysToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.next7DaysToolStripMenuItem.Text = "Next &7 Days";
            this.next7DaysToolStripMenuItem.Click += new System.EventHandler(this.next7DaysToolStripMenuItem_Click);
            // 
            // next14DaysToolStripMenuItem
            // 
            this.next14DaysToolStripMenuItem.Checked = true;
            this.next14DaysToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.next14DaysToolStripMenuItem.Name = "next14DaysToolStripMenuItem";
            this.next14DaysToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.next14DaysToolStripMenuItem.Text = "Next 1&4 Days";
            this.next14DaysToolStripMenuItem.Click += new System.EventHandler(this.next14DaysToolStripMenuItem_Click);
            // 
            // next21DaysToolStripMenuItem
            // 
            this.next21DaysToolStripMenuItem.Name = "next21DaysToolStripMenuItem";
            this.next21DaysToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.next21DaysToolStripMenuItem.Text = "Next 2&1 Days";
            this.next21DaysToolStripMenuItem.Click += new System.EventHandler(this.next21DaysToolStripMenuItem_Click);
            // 
            // next28DaysToolStripMenuItem
            // 
            this.next28DaysToolStripMenuItem.Name = "next28DaysToolStripMenuItem";
            this.next28DaysToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.next28DaysToolStripMenuItem.Text = "Next 2&8 Days";
            this.next28DaysToolStripMenuItem.Click += new System.EventHandler(this.next28DaysToolStripMenuItem_Click);
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(0, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(563, 24);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "The Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 310);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remindersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem next7DaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem next14DaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem next21DaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem next28DaysToolStripMenuItem;
        private System.Windows.Forms.Label labelDate;
    }
}

