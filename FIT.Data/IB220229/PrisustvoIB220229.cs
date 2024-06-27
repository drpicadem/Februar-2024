using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220229
{
    [Table("PrisustvoIB220229")]
    public class PrisustvoIB220229
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public NastavaIB220229 Nastava { get; set; }
        public int NastavaId { get; set; }

    }
}
