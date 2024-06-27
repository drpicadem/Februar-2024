using FIT.Data.IB220229;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmNastavaIB220229 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        ProstorijeIB220229 prostorija;
        public frmNastavaIB220229(ProstorijeIB220229 Oprostorija)
        {
            prostorija = Oprostorija;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmNastavaIB220229_Load(object sender, EventArgs e)
        {
            label1.Text = prostorija.NazivProstorije + " " + prostorija.Oznaka;
            comboBox1.DataSource = db.Predmet.ToList();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Nastava.Include(p => p.Predmet).Where(p => p.ProstorijaId == prostorija.Id).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var lista = dataGridView1.DataSource as List<NastavaIB220229>;
            if (lista != null)
                foreach (var item in lista)
                {
                    if (item.Vrijeme == comboBox3.Text && item.Dan == comboBox2.Text)
                    {
                        MessageBox.Show("Vec postoji nastava u ovome vremenu!");
                        return;
                    }
                }
            var nastava = new NastavaIB220229()
            {
                PredmetId = (comboBox1.SelectedItem as PredmetIB220229).Id,
                Dan = comboBox2.Text,
                Vrijeme = comboBox3.Text,
                ProstorijaId = prostorija.Id,
                Oznaka = (comboBox1.SelectedItem as PredmetIB220229).Naziv+"::"+comboBox2.Text+"@"+comboBox3.Text,
            };
            db.Add(nastava);
            db.SaveChanges();
            LoadData();
        }
    }
}
