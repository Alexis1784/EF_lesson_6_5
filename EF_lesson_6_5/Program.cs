using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_lesson_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MobileContext db = new MobileContext())
            {
                PhoneInfo pi1 = new PhoneInfo { PhoneId = 1, Company = "Samsung", Price = 14000 };
                PhoneInfo pi2 = new PhoneInfo { PhoneId = 2, Company = "Nokia", Price = 8000 };

                Phone p1 = new Phone { PhoneId = 1, Name = "Samsung Galaxy S5", Info = pi1 };
                Phone p2 = new Phone { PhoneId = 2, Name = "Nokia Lumia 630", Info = pi2 };

                db.Infos.Add(pi1);
                db.Infos.Add(pi2);
                db.Phones.Add(p1);
                db.Phones.Add(p2);
                db.SaveChanges();

                foreach (Phone p in db.Phones.Include(p => p.Info))
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Info.Company, p.Info.Price);
            }
            Console.ReadLine();
        }
    }
}
