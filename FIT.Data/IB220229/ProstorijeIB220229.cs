using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220229
{
    [Table("ProstorijeIB220229")]
    public class ProstorijeIB220229
    {
        public int Id { get; set; }
        public string NazivProstorije { get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public Image Slika => Image.FromStream(new MemoryStream(Logo));
        public int Kapacitet { get; set; }
        [NotMapped]
        public int BrojPredmeta { get; set; }
    }
}
