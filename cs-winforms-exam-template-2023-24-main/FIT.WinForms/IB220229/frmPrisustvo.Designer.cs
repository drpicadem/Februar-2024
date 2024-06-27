namespace FIT.WinForms.IB220229
{
    partial class frmPrisustvo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbNastava = new ComboBox();
            cbStudent = new ComboBox();
            btnDodaj = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            rtbInfo = new RichTextBox();
            label6 = new Label();
            tbBrojZapisa = new TextBox();
            btnGenerisi = new Button();
            label5 = new Label();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(785, 33);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 65);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Nastava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 65);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Student:";
            // 
            // cbNastava
            // 
            cbNastava.FormattingEnabled = true;
            cbNastava.Location = new Point(33, 88);
            cbNastava.Name = "cbNastava";
            cbNastava.Size = new Size(225, 28);
            cbNastava.TabIndex = 4;
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(307, 88);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(287, 28);
            cbStudent.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(755, 87);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(32, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(888, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbInfo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbBrojZapisa);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(33, 332);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 236);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(15, 113);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(663, 105);
            rtbInfo.TabIndex = 12;
            rtbInfo.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 90);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 11;
            label6.Text = "Info:";
            // 
            // tbBrojZapisa
            // 
            tbBrojZapisa.Location = new Point(106, 44);
            tbBrojZapisa.Name = "tbBrojZapisa";
            tbBrojZapisa.Size = new Size(61, 27);
            tbBrojZapisa.TabIndex = 10;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(197, 44);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 9;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 44);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 9;
            label5.Text = "Broj zapisa:";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Slika";
            Column1.HeaderText = "Logo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "NazivProstorije";
            Column2.HeaderText = "Naziv";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Oznaka";
            Column3.HeaderText = "Oznaka";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Kapacitet";
            Column4.HeaderText = "Kapacitet";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Br.predmeta";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Nastava";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Prisustvo";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 125;
            // 
            // frmProstorije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 580);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDodaj);
            Controls.Add(cbStudent);
            Controls.Add(cbNastava);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProstorije";
            Text = "frmPrisustvo";
            Load += frmProstorije_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbNastava;
        private ComboBox cbStudent;
        private Button btnDodaj;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RichTextBox rtbInfo;
        private Label label6;
        private TextBox tbBrojZapisa;
        private Button btnGenerisi;
        private Label label5;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}