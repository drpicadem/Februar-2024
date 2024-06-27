namespace FIT.WinForms.IB220229
{
    partial class frmNastava
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
            cbPredmet = new ComboBox();
            cbDan = new ComboBox();
            cbVrijeme = new ComboBox();
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 77);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 77);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Dan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 77);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Vrijeme";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbPredmet
            // 
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(31, 110);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(151, 28);
            cbPredmet.TabIndex = 4;
            // 
            // cbDan
            // 
            cbDan.FormattingEnabled = true;
            cbDan.Location = new Point(276, 110);
            cbDan.Name = "cbDan";
            cbDan.Size = new Size(151, 28);
            cbDan.TabIndex = 5;
            // 
            // cbVrijeme
            // 
            cbVrijeme.FormattingEnabled = true;
            cbVrijeme.Location = new Point(446, 110);
            cbVrijeme.Name = "cbVrijeme";
            cbVrijeme.Size = new Size(151, 28);
            cbVrijeme.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(726, 188);
            dataGridView1.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(653, 109);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // frmNastava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridView1);
            Controls.Add(cbVrijeme);
            Controls.Add(cbDan);
            Controls.Add(cbPredmet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNastava";
            Text = "frmNastava";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbPredmet;
        private ComboBox cbDan;
        private ComboBox cbVrijeme;
        private DataGridView dataGridView1;
        private Button btnDodaj;
    }
}