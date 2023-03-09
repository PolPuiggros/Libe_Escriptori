using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static string Delete(departments dept)
        {
            string missatges = "";
            try
            {
                dept = Orm.db.departments
                    .Where(d => d.id == dept.id)
                    .FirstOrDefault();
                dept.active = false;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }
    }
}
