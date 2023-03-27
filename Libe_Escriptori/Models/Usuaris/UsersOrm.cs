using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static string Insert(users _users)
        {
            string message = "";
            try
            {
                Orm.db.users.Add(_users);
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
