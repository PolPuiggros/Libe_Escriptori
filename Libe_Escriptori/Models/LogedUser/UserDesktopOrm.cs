using System;
using System.Collections.Generic;
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

        public static void UpdateImage(string imageName)
        {
            users_desktop user = Orm.db.users_desktop
                .Where(c => c.active == true)
                .FirstOrDefault();
            user.profile_img = imageName;
            Orm.MySaveChanges();
        }
    }
}
