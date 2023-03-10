using System;
using System.Collections.Generic;
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

        public static void Insert(profesors _profesors)
        {
            Orm.db.profesors.Add(_profesors);
            Orm.db.SaveChanges();
        }

        public static void Delete(profesors _profesors)
        {
            _profesors = Orm.db.profesors
                .Where(c => c.id == _profesors.id)
                .First();
            _profesors.active = false;
            _profesors.users.active = false;
            _profesors.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }
        public static void Update(profesors _profesor, string name, string surname, string surname2, string email, string phone, List<departments> _departments)
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
    }
}
