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
            _students.users.active = false;
            _students.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }

        public static void Insert(students _students)
        {
            Orm.db.students.Add(_students);
            Orm.db.SaveChanges();
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

        public static void Update(students _student, string name, string surname, string surname2, string email, string dni, string phone, bool autoregister, bool repiter, List<units> _units)
        {
            _student = Orm.db.students
                .Where(c => c.id == _student.id)
                .First();

            if (!_student.name.Equals(name))
            {
                _student.name = name;
            }
            if (!_student.surname.Equals(surname))
            {
                _student.surname = surname;
            }
            if (!_student.surname2.Equals(surname2))
            {
                _student.surname2 = surname2;
            }
            if (!_student.email.Equals(email))
            {
                _student.email = email;
            }
            if (!_student.dni.Equals(dni))
            {
                _student.dni = dni;
            }
            if (!_student.phone_number.Equals(phone))
            {
                _student.phone_number = phone;
            }
            if (_student.autoregister != autoregister)
            {
                _student.autoregister = autoregister;
            }
            if (_student.has_repeated != repiter)
            {
                _student.has_repeated = repiter;
            }
            if (_student.units != _units)
            {
                _student.units = _units;
            }
            _student.updated_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }
    }
    
}
