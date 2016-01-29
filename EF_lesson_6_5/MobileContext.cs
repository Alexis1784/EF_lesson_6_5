using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_5
{
    class MobileContext : DbContext
    {
        public MobileContext()
            : base("DefaultConnection")
        { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneInfo> Infos { get; set; }
    }
}
