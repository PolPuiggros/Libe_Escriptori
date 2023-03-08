using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class GroupsOrm
    {
        public static List<groups> Select()
        {
            List<groups> _groups = Orm.db.groups.ToList();

            return _groups;
        }
    }
}
