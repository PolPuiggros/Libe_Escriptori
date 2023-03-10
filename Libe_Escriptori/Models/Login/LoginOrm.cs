using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Login
{
    public static class LoginOrm
    {
        public static string Select(bool active, string username)
        {
            string _password = Orm.db.users_desktop
                .Where(c => c.active == active && c.username.Equals(username))
                .Select(column => column.password)
                .FirstOrDefault();
            return _password;
        }
    }
}
