namespace PasswordGenForm
{
    partial class Passgen
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordLengthToolStripMenuItem,
            this.toolStripSeparator1,
            this.specialCharactersToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // passwordLengthToolStripMenuItem
            // 
            this.passwordLengthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem,
            this.charactersToolStripMenuItem1,
            this.charactersToolStripMenuItem2,
            this.charactersToolStripMenuItem3,
            this.charactersToolStripMenuItem4,
            this.charactersToolStripMenuItem5,
            this.charactersToolStripMenuItem6});
            this.passwordLengthToolStripMenuItem.Name = "passwordLengthToolStripMenuItem";
            this.passwordLengthToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.passwordLengthToolStripMenuItem.Text = "Password Length";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem.Text = "9 Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // charactersToolStripMenuItem1
            // 
            this.charactersToolStripMenuItem1.Name = "charactersToolStripMenuItem1";
            this.charactersToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem1.Text = "10 Characters";
            this.charactersToolStripMenuItem1.Click += new System.EventHandler(this.charactersToolStripMenuItem1_Click);
            // 
            // charactersToolStripMenuItem2
            // 
            this.charactersToolStripMenuItem2.Name = "charactersToolStripMenuItem2";
            this.charactersToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem2.Text = "11 Characters";
            this.charactersToolStripMenuItem2.Click += new System.EventHandler(this.charactersToolStripMenuItem2_Click);
            // 
            // charactersToolStripMenuItem3
            // 
            this.charactersToolStripMenuItem3.Name = "charactersToolStripMenuItem3";
            this.charactersToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem3.Text = "12 Characters";
            this.charactersToolStripMenuItem3.Click += new System.EventHandler(this.charactersToolStripMenuItem3_Click);
            // 
            // charactersToolStripMenuItem4
            // 
            this.charactersToolStripMenuItem4.Name = "charactersToolStripMenuItem4";
            this.charactersToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem4.Text = "13 Characters";
            this.charactersToolStripMenuItem4.Click += new System.EventHandler(this.charactersToolStripMenuItem4_Click);
            // 
            // charactersToolStripMenuItem5
            // 
            this.charactersToolStripMenuItem5.Name = "charactersToolStripMenuItem5";
            this.charactersToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem5.Text = "14 Characters";
            this.charactersToolStripMenuItem5.Click += new System.EventHandler(this.charactersToolStripMenuItem5_Click);
            // 
            // charactersToolStripMenuItem6
            // 
            this.charactersToolStripMenuItem6.Name = "charactersToolStripMenuItem6";
            this.charactersToolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.charactersToolStripMenuItem6.Text = "15 Characters";
            this.charactersToolStripMenuItem6.Click += new System.EventHandler(this.charactersToolStripMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(89, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(60, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(218, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // specialCharactersToolStripMenuItem
            // 
            this.specialCharactersToolStripMenuItem.Name = "specialCharactersToolStripMenuItem";
            this.specialCharactersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.specialCharactersToolStripMenuItem.Text = "Special Characters";
            this.specialCharactersToolStripMenuItem.Click += new System.EventHandler(this.SpecialCharactersToolStripMenuItem_Click);
            // 
            // Passgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 203);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(425, 250);
            this.Name = "Passgen";
            this.Text = "Secure Password Generator~";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem specialCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

