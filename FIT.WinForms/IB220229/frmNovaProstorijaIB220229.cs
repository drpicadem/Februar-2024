using FIT.Data;
using FIT.Data.IB220229;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
    public partial class frmNovaProstorijaIB220229 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        ProstorijeIB220229 prostorijeIB220229;
        public frmNovaProstorijaIB220229(ProstorijeIB220229 Oprostorije = null)
        {
            InitializeComponent();
            prostorijeIB220229 = Oprostorije;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helpers.Validator.ProvjeriUnos(textBox1, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(textBox2, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(textBox3, errorProvider1, Kljucevi.ReqiredValue) &&
                (Helpers.Validator.ProvjeriUnos(pictureBox1, errorProvider1, Kljucevi.ReqiredValue)))))
            {
                try
                {
                    if (prostorijeIB220229 == null)
                    {
                        var Prostorija = new ProstorijeIB220229()
                        {
                            NazivProstorije = textBox1.Text,
                            Oznaka = textBox2.Text,
                            Kapacitet = int.Parse(textBox3.Text),
                            Logo = Helpers.Ekstenzije.ToByteArray(pictureBox1.Image)
                        };
                        db.Add(Prostorija);
                        db.SaveChanges();
                    }
                    else
                    {
                        prostorijeIB220229.Logo = Helpers.Ekstenzije.ToByteArray(pictureBox1.Image);
                        prostorijeIB220229.NazivProstorije = textBox1.Text;
                        prostorijeIB220229.Oznaka = textBox2.Text;
                        prostorijeIB220229.Kapacitet = int.Parse(textBox3.Text);  
                        db.Prostorije.Update(prostorijeIB220229);
                        db.SaveChanges();
                    }

                }

                catch
                {

                    MessageBox.Show("Niste lepo uneli podatke");
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void frmNovaProstorijaIB220229_Load(object sender, EventArgs e)
        {
            if (prostorijeIB220229 != null)
            {
                pictureBox1.Image = prostorijeIB220229.Slika;
                textBox1.Text     = prostorijeIB220229.NazivProstorije;
                textBox2.Text     = prostorijeIB220229.Oznaka;
                textBox3.Text     = prostorijeIB220229.Kapacitet.ToString();
            }
        }
    }
}

