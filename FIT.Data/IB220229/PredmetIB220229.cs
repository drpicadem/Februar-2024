using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220229
{
    [Table("Predmeti")]
    public class PredmetIB220229
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Semestar { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
