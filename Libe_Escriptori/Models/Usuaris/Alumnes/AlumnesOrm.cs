using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Usuaris.Alumnes
{
    public static class AlumnesOrm
    {
        public static List<students> Select(bool active)
        {
            List<students> _students = Orm.db.students
                .Where(c => c.active == active)
                .ToList();


            return _students;
        }
        public static void Delete(students _students)
        {
            _students = Orm.db.students
                .Where(c => c.id == _students.id)
                .First();
            _students.active = false;
            Orm.db.SaveChanges();
        }
    }
}
