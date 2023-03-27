using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static string Delete(students _students)
        {
            string message = "";
            try
            {
                _students = Orm.db.students
                    .Where(c => c.id == _students.id)
                    .First();
                _students.active = false;
                _students.users.active = false;
                _students.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Insert(students _students)
        {
            string message = "";
            try
            {
                Orm.db.students.Add(_students);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }
        public static List<students> SelectStudentsCourses(bool active, int idCourse)
        {
            List<students> _students = Orm.db.students
                .Where(student => student.active == active && student.units.Any(unit => unit.modules.courses.Any(course => course.id == idCourse)))
                .ToList();
            return _students;
        }

        public static List<students> SelectStudentsGroup (int idGroup)
        {
            List<students> _students = Orm.db.students
                .Where(student => student.active == true && student.group_id == idGroup)
                .ToList();
            return _students;
        }

        public static string Update(students _student)
        {
            string message = "";
            try
            {
                students student = Orm.db.students
                    .Where(c => c.id == _student.id)
                    .First();


                student.name = _student.name;
                student.surname = _student.surname;
                student.surname2 = _student.surname2;
                student.email = _student.email;
                student.dni = _student.dni;
                student.phone_number = _student.phone_number;
                student.autoregister = _student.autoregister;
                student.has_repeated = _student.has_repeated;
                student.units = _student.units;
                student.updated_timestamp = DateTime.Now;
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
