namespace WindowsFormsApplication10
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nastavnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Odeljenje = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Menjaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nastavnik,
            this.Godina,
            this.Predmet,
            this.Odeljenje,
            this.Dodaj,
            this.Menjaj,
            this.Obrisi});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 398);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(38, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "MENJAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(689, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 398);
            this.panel1.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // Nastavnik
            // 
            this.Nastavnik.HeaderText = "Nastavnik";
            this.Nastavnik.MinimumWidth = 6;
            this.Nastavnik.Name = "Nastavnik";
            this.Nastavnik.Width = 125;
            // 
            // Godina
            // 
            this.Godina.HeaderText = "Godina";
            this.Godina.MinimumWidth = 6;
            this.Godina.Name = "Godina";
            this.Godina.Width = 125;
            // 
            // Predmet
            // 
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.Width = 125;
            // 
            // Odeljenje
            // 
            this.Odeljenje.HeaderText = "Odeljenje";
            this.Odeljenje.MinimumWidth = 6;
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Width = 125;
            // 
            // Dodaj
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dodaj.HeaderText = "Dodaj";
            this.Dodaj.MinimumWidth = 6;
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Text = "+";
            this.Dodaj.UseColumnTextForButtonValue = true;
            this.Dodaj.Width = 50;
            // 
            // Menjaj
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menjaj.DefaultCellStyle = dataGridViewCellStyle14;
            this.Menjaj.HeaderText = "Menjaj";
            this.Menjaj.MinimumWidth = 6;
            this.Menjaj.Name = "Menjaj";
            this.Menjaj.Text = "↺";
            this.Menjaj.UseColumnTextForButtonValue = true;
            this.Menjaj.Width = 50;
            // 
            // Obrisi
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obrisi.DefaultCellStyle = dataGridViewCellStyle15;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Text = "X";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 50;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(842, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "RASPODELA";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Nastavnik;
        private System.Windows.Forms.DataGridViewComboBoxColumn Godina;
        private System.Windows.Forms.DataGridViewComboBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewComboBoxColumn Odeljenje;
        private System.Windows.Forms.DataGridViewButtonColumn Dodaj;
        private System.Windows.Forms.DataGridViewButtonColumn Menjaj;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}