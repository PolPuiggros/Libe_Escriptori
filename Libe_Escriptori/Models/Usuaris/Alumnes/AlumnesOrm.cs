using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Usuaris.Alumnes
{
    public static class AlumnesOrm
    {
        public static List<students> Select()
        {
            List<students> _students = Orm.db.students
                .ToList();


            return _students;
        }
        public static void Delete(students _students)
        {
            Orm.db.students.Remove(_students);
            Orm.db.SaveChanges();
        }
    }
}
