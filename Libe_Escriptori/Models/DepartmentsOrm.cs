using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class DepartmentsOrm
    {
        public static List<departments> Select(bool active)
        {
            List<departments> _departments = Orm.db.departments
                .Where(c => c.active == active)
                .ToList();


            return _departments;
        }
        public static void Insert(departments _departments)
        {
            Orm.db.departments.Add(_departments);
            Orm.db.SaveChanges();
        }
    }
}
