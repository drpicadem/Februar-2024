using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220229
{
    [Table("NastavaIB220229")]
    public class NastavaIB220229
    {
        public int Id { get; set; }
        public ProstorijeIB220229 Prostorija { get; set; }
        public int ProstorijaId { get; set; }
        public PredmetIB220229 Predmet { get; set; }
        public int PredmetId { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
    }
}
