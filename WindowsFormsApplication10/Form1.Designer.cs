namespace WindowsFormsApplication10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCENEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pToolStripMenuItem,
            this.oCENEToolStripMenuItem,
            this.kToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.smerToolStripMenuItem,
            this.sToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.menuToolStripMenuItem.Text = "Šifarnici";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sToolStripMenuItem.Text = "Osoba";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.sToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sToolStripMenuItem1.Text = "Upisnica";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.sToolStripMenuItem1_Click);
            // 
            // smerToolStripMenuItem
            // 
            this.smerToolStripMenuItem.Name = "smerToolStripMenuItem";
            this.smerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smerToolStripMenuItem.Text = "Raspodela";
            this.smerToolStripMenuItem.Click += new System.EventHandler(this.smerToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pToolStripMenuItem.Text = "Odeljena";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // oCENEToolStripMenuItem
            // 
            this.oCENEToolStripMenuItem.Name = "oCENEToolStripMenuItem";
            this.oCENEToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.oCENEToolStripMenuItem.Text = "Ocene";
            this.oCENEToolStripMenuItem.Click += new System.EventHandler(this.oCENEToolStripMenuItem_Click);
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kToolStripMenuItem.Text = "Izveštaji";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "EsDnevnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "David Milenković";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EsDnevnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem oCENEToolStripMenuItem;
    }
}

