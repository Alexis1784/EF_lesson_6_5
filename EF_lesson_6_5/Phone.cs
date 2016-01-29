using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_5
{
    [Table("Mobiles")]
    public class Phone
    {
        [Key, ForeignKey("Info")]
        public int PhoneId { get; set; }
        public string Name { get; set; }

        public PhoneInfo Info { get; set; }
    }
}
