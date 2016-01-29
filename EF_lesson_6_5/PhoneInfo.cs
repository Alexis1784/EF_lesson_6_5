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
    public class PhoneInfo
    {
        [Key, ForeignKey("Phone")]
        public int PhoneId { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public Phone Phone { get; set; }
    }
}
