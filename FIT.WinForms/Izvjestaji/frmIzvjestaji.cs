using FIT.Data.IB220229;
using FIT.Infrastructure;
using FIT.WinForms.IB220229;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Linq;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        ProstorijeIB220229 prostorije;
        DLWMSDbContext db=new DLWMSDbContext();
        public frmIzvjestaji(ProstorijeIB220229 _prostorija)
        {
            InitializeComponent();
            prostorije = _prostorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            List<NastavaIB220229>nastava=db.Nastava.Where(p=>p.ProstorijaId==prostorije.Id).ToList();
            List<NastavaStudent> nastavaStudents = new List<NastavaStudent>();

            var brojStudenata = db.Studenti.Count().ToString();
            var nazivProstorije = prostorije.NazivProstorije.ToString();
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pBrojStudenata", brojStudenata));
            rpc.Add(new ReportParameter("pNazivProstorije", nazivProstorije));
            reportViewer1.LocalReport.SetParameters(rpc);
            foreach (var item in nastava)
            {
               nastavaStudents.AddRange(db.NasStu.Include(p=>p.Nastava).Include(p=>p.Student).Include(p=>p.Nastava.Predmet)
                   .Where(P=>P.NastavaId==item.Id).ToList());
            }
            var rds = new ReportDataSource();
            var tabela = new dsIB220229.dtNastavaDataTable();
            var i = 1;
            foreach (var item in nastavaStudents)
            {
                var red = tabela.NewdtNastavaRow();
                red.Rb = i++.ToString();
                red.Predmet=item.Nastava.Predmet.ToString ();   
                red.Vrijeme=item.Nastava.Vrijeme.ToString ();
                red.ImePrezime = item.Student.Ime + " " + item.Student.Prezime;
                red.BrojIndeksa=item.Student.Indeks.ToString ();
                tabela.Rows.Add(red);
            }
            rds.Value = tabela;
            rds.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
