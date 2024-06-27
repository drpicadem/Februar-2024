using FIT.Data;
using FIT.Data.IB220229;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPrisustvoIB220229 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        ProstorijeIB220229 prostorija;
        public frmPrisustvoIB220229(ProstorijeIB220229 Oprostorija)
        {
            InitializeComponent();
            prostorija = Oprostorija;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPrisustvoIB220229_Load(object sender, EventArgs e)
        {
            label1.Text = prostorija.NazivProstorije + "-" + prostorija.Oznaka;
            label2.Text = dataGridView1.RowCount.ToString() + "/" + prostorija.Kapacitet.ToString();
            comboBox1.DataSource = db.Nastava.Where(p => p.ProstorijaId == prostorija.Id).ToList();
            comboBox2.DataSource = db.Studenti.ToList();
            LoadData();
        }

        private void LoadData()
        {
            var ONastava = (comboBox1.SelectedItem as NastavaIB220229);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.NasStu.Include(p => p.Nastava).Include(p => p.Student)
                .Where(p => p.NastavaId == ONastava.Id).ToList();
            label2.Text = dataGridView1.RowCount.ToString() + "/" + prostorija.Kapacitet.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nastava = comboBox1.SelectedItem as NastavaIB220229;
            var student = comboBox2.SelectedItem as Student;
            if (dataGridView1.RowCount >= prostorija.Kapacitet)
            {
                MessageBox.Show("Nema mjesta!!!");
                return;
            }
            if (db.NasStu.Where(p => p.NastavaId == nastava.Id && p.StudentId == student.Id).Any())
            {
                MessageBox.Show("Postoje");
                return;
            }
            var NastStu = new NastavaStudent()
            {
                NastavaId = nastava.Id,
                StudentId = student.Id
            };
            db.NasStu.Add(NastStu);
            db.SaveChanges();
            LoadData();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var student=comboBox2.SelectedItem as Student;
            var nastava = comboBox1.DataSource as List<NastavaIB220229>;
            var broj = int.Parse(textBox1.Text);
            await Task.Run(async () => { 
            for (int i = 0; i < broj; i++)
                {
                    foreach (var item in nastava)
                    {
                        var NastStu = new NastavaStudent()
                        {
                            NastavaId = item.Id,
                            StudentId = student.Id
                        };
                        db.Add(NastStu);
                        await Task.Delay(30);
                        richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText("$Dodatooo\n");
                            richTextBox1.SelectionStart = richTextBox1.Text.Length;
                            richTextBox1.ScrollToCaret();
                        }));
                    }
                }
                MessageBox.Show("Dodavanje zavrseno!!!");
                db.SaveChanges();
            });
            
            LoadData();    
        }
    }
}
