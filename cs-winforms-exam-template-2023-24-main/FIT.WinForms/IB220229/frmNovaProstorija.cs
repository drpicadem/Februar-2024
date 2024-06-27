using FIT.Data;
using FIT.Data.IB220229;
using FIT.Infrastructure;
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
    public partial class frmNovaProstorija : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorija()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Helpers.Validator.ProvjeriUnos(pictureBox1, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(textBox1, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(textBox2, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(textBox3, errorProvider1, Kljucevi.ReqiredValue)))))
            {
                try
                {
                    var prostorija = new ProstorijeIB220229()
                    {
                        NazivProstorije = textBox1.Text,
                        Oznaka = textBox2.Text,
                        Kapacitet = int.Parse(textBox3.Text),
                        Logo = Helpers.Ekstenzije.ToByteArray(pictureBox1.Image)
                    };
                    db.Add(prostorija);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Unesite validne vrijednosti.");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd=new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
