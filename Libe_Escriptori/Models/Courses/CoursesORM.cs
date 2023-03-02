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
                .ToList();

            return courses;


        }

    }
}
