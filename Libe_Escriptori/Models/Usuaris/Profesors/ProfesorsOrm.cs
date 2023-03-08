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
    }
}
