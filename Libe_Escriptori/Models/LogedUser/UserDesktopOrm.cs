using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Libe_Escriptori.Models.Login
{
    public static class UserDesktopOrm
    {
        public static string Select(bool active, string username)
        {
            string _password = Orm.db.users_desktop
                .Where(c => c.active == active && c.username.Equals(username))
                .Select(column => column.password)
                .FirstOrDefault();
            return _password;
        }
        public static users_desktop SelectUser(bool active, string username)
        {
            users_desktop user = Orm.db.users_desktop
                .Where(c => c.active == active && c.username.Equals(username))
                .FirstOrDefault();
            return user;
        }

        public static string UpdateImage(string imageName)
        {
            string message = "";
            try
            {
                users_desktop user = Orm.db.users_desktop
                    .Where(c => c.active == true)
                    .FirstOrDefault();
                user.profile_img = imageName;
                Orm.MySaveChanges();
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
