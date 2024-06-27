namespace FIT.WinForms.IB220229
{
    partial class frmProstorije
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
            btnNovaP = new Button();
            btnPrintaj = new Button();
            dgvProstorije = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // btnNovaP
            // 
            btnNovaP.Location = new Point(630, 22);
            btnNovaP.Name = "btnNovaP";
            btnNovaP.Size = new Size(142, 29);
            btnNovaP.TabIndex = 0;
            btnNovaP.Text = "Nova prostorija";
            btnNovaP.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(678, 387);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Location = new Point(12, 73);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.RowTemplate.Height = 29;
            dgvProstorije.Size = new Size(760, 291);
            dgvProstorije.TabIndex = 2;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProstorije);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaP);
            Name = "frmPocetna";
            Text = "frmPocetna";
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaP;
        private Button btnPrintaj;
        private DataGridView dgvProstorije;
    }
}