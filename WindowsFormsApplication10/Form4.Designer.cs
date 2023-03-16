namespace WindowsFormsApplication10
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.esdnevnikDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esdnevnikDataSet = new WindowsFormsApplication10.esdnevnikDataSet();
            this.esdnevnikDataSet1 = new WindowsFormsApplication10.esdnevnikDataSet1();
            this.ocenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenaTableAdapter = new WindowsFormsApplication10.esdnevnikDataSet1TableAdapters.OcenaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Menjaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Dodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ocena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ime_i_prezime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // esdnevnikDataSetBindingSource
            // 
            this.esdnevnikDataSetBindingSource.DataSource = this.esdnevnikDataSet;
            this.esdnevnikDataSetBindingSource.Position = 0;
            // 
            // esdnevnikDataSet
            // 
            this.esdnevnikDataSet.DataSetName = "esdnevnikDataSet";
            this.esdnevnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // esdnevnikDataSet1
            // 
            this.esdnevnikDataSet1.DataSetName = "esdnevnikDataSet1";
            this.esdnevnikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocenaBindingSource
            // 
            this.ocenaBindingSource.DataMember = "Ocena";
            this.ocenaBindingSource.DataSource = this.esdnevnikDataSet1;
            // 
            // ocenaTableAdapter
            // 
            this.ocenaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Datum,
            this.Ime_i_prezime,
            this.Ocena,
            this.Predmet,
            this.Dodaj,
            this.Menjaj,
            this.Obrisi});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(38, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 329);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(715, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 329);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(40, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "MENJAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Obrisi
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Obrisi.DefaultCellStyle = dataGridViewCellStyle3;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Text = "X";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 50;
            // 
            // Menjaj
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Menjaj.DefaultCellStyle = dataGridViewCellStyle2;
            this.Menjaj.HeaderText = "Menjaj";
            this.Menjaj.MinimumWidth = 6;
            this.Menjaj.Name = "Menjaj";
            this.Menjaj.Text = "↺";
            this.Menjaj.UseColumnTextForButtonValue = true;
            this.Menjaj.Width = 50;
            // 
            // Dodaj
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            this.Dodaj.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dodaj.HeaderText = "Dodaj";
            this.Dodaj.MinimumWidth = 6;
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Text = "+";
            this.Dodaj.UseColumnTextForButtonValue = true;
            this.Dodaj.Width = 50;
            // 
            // Predmet
            // 
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.Sorted = true;
            this.Predmet.Width = 125;
            // 
            // Ocena
            // 
            this.Ocena.HeaderText = "Ocena";
            this.Ocena.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Ocena.MinimumWidth = 6;
            this.Ocena.Name = "Ocena";
            this.Ocena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ocena.Sorted = true;
            this.Ocena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ocena.Width = 125;
            // 
            // Ime_i_prezime
            // 
            this.Ime_i_prezime.HeaderText = "Ucenik";
            this.Ime_i_prezime.MinimumWidth = 6;
            this.Ime_i_prezime.Name = "Ime_i_prezime";
            this.Ime_i_prezime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ime_i_prezime.Sorted = true;
            this.Ime_i_prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ime_i_prezime.Width = 125;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(910, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form4";
            this.Text = "OCENE";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdnevnikDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource esdnevnikDataSetBindingSource;
        private esdnevnikDataSet esdnevnikDataSet;
        private esdnevnikDataSet1 esdnevnikDataSet1;
        private System.Windows.Forms.BindingSource ocenaBindingSource;
        private esdnevnikDataSet1TableAdapters.OcenaTableAdapter ocenaTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ime_i_prezime;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ocena;
        private System.Windows.Forms.DataGridViewComboBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewButtonColumn Dodaj;
        private System.Windows.Forms.DataGridViewButtonColumn Menjaj;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}