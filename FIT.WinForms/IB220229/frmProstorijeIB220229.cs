using FIT.Data.IB220229;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmProstorijeIB220229 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        ProstorijeIB220229 prostorija = null;
        public frmProstorijeIB220229()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmProstorijeIB220229_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData(List<ProstorijeIB220229> list = null)
        {
            var lista = list ?? db.Prostorije.ToList();
            foreach (var prostorije in lista)
            {
                prostorije.BrojPredmeta = db.Nastava.Where(p => p.ProstorijaId == prostorije.Id).Count();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list ?? db.Prostorije.ToList();

        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            new frmNovaProstorijaIB220229().ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                new frmNastavaIB220229(dataGridView1.Rows[e.RowIndex].DataBoundItem as ProstorijeIB220229).ShowDialog();
                LoadData();
            }
            if (e.ColumnIndex == 6)
            {
                new frmPrisustvoIB220229(dataGridView1.Rows[e.RowIndex].DataBoundItem as ProstorijeIB220229).ShowDialog();
                LoadData();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            var prostorija = dataGridView1.Rows[e.RowIndex].DataBoundItem as ProstorijeIB220229;
            new frmNovaProstorijaIB220229(prostorija).ShowDialog();
            LoadData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            prostorija = dataGridView1.Rows[e.RowIndex].DataBoundItem as ProstorijeIB220229;
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if (prostorija==null)
            {
                MessageBox.Show("Nisi odabro ljudino");
                return;
            }
            else
            {
                new frmIzvjestaji(prostorija).ShowDialog();
            }
        }
    }
}
