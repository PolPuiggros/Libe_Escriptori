using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static string Delete(courses _courses)
        {
            string message = "";
            try
            {
                _courses = Orm.db.courses
                    .Where(c => c.id == _courses.id)
                    .First();
                _courses.active = false;
                _courses.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            } 
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Insert(courses _courses)
        {
            string message = "";
            try
            {
                Orm.db.courses.Add(_courses);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Update(courses _courses)
        {
            string message = "";
            try
            {
                courses course = Orm.db.courses
                    .Where(c => c.id == _courses.id)
                    .First();

                course.abreviation = _courses.abreviation;
                course.name = _courses.name;
                course.total_hours = _courses.total_hours;
                course.department_id = _courses.department_id;
                course.modules = _courses.modules;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;

        }

    }
}
