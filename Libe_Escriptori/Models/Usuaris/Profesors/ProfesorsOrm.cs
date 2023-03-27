using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Usuaris.Profesors
{
    public static class ProfesorsOrm
    {
        public static List<profesors> Select(bool active)
        {
            List<profesors> _profesors = Orm.db.profesors
                .Where(c => c.active == active)
                .ToList();


            return _profesors;
        }

        public static profesors SelectFromId(int id)
        {
            profesors _profesors = Orm.db.profesors
                .Where(c => c.id == id)
                .FirstOrDefault();


            return _profesors;
        }

        public static string Insert(profesors _profesors)
        {
            string message = "";
            try
            {
                Orm.db.profesors.Add(_profesors);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Delete(profesors _profesors)
        {
            string message = "";
            try
            {
                _profesors = Orm.db.profesors
                    .Where(c => c.id == _profesors.id)
                    .First();
                _profesors.active = false;
                _profesors.users.active = false;
                _profesors.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }
        public static string Update(profesors _profesor, string name, string surname, string surname2, string email, string phone, List<departments> _departments)
        {
            string message = "";
            try
            {
                _profesor = Orm.db.profesors
                    .Where(c => c.id == _profesor.id)
                    .First();

                if (!_profesor.name.Equals(name))
                {
                    _profesor.name = name;
                }
                if (!_profesor.surname1.Equals(surname))
                {
                    _profesor.surname1 = surname;
                }
                if (!_profesor.surname2.Equals(surname2))
                {
                    _profesor.surname2 = surname2;
                }
                if (!_profesor.email.Equals(email))
                {
                    _profesor.email = email;
                }
                if (!_profesor.phone_number.Equals(phone))
                {
                    _profesor.phone_number = phone;
                }
                if (_profesor.departments != _departments)
                {
                    _profesor.departments = _departments;
                }
                _profesor.updated_timestamp = DateTime.Now;
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
