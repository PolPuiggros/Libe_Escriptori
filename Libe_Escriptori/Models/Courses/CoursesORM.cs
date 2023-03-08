using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Courses
{
    public static class CoursesORM
    {
        public static List<courses> Select()
        {
            List<courses> courses = Orm.db.courses
                .Where(c => c.active == true)
                .ToList();

            return courses;


        }
        public static courses Select(int id)
        {
            courses _courses = Orm.db.courses
                .Where(c => c.id == id)
                .First();
            return _courses;
        }

        public static void Delete(courses _courses)
        {
            _courses = Orm.db.courses
                .Where(c => c.id == _courses.id)
                .First();
            _courses.active = false;
            _courses.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }

    }
}
