using FIT.Data.IB220229;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220229
{
    public partial class frmPrisustvo : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPrisustvo()
        {
            InitializeComponent();
        }

        private void frmProstorije_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadData();
        }

        public void LoadData(List<ProstorijeIB220229> list = null)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list ?? db.Prostorije.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new frmNovaProstorija().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex<0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                new frmNastava().ShowDialog();
                LoadData();
            }
            if(e.ColumnIndex == 6)
            {
                new frmProstorije().ShowDialog();
            }
        }
    }
}
