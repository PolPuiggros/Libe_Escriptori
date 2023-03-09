using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class UsersOrm
    {
        public static int Select(String username)
        {
            int id_user = Orm.db.users
                .Where(c => c.username == username)
                .Select(column => column.id)
                .FirstOrDefault();

            return id_user;
        }

        public static void Insert(users _users)
        {
            Orm.db.users.Add(_users);
            Orm.db.SaveChanges();
        }
    }
}
