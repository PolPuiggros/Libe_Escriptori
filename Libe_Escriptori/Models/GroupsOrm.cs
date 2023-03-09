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

        public static groups SelectGroup(int id_group)
        {
            groups _group = Orm.db.groups
                .Where(group => group.id == id_group)
                .FirstOrDefault();

            return _group;
        }
    }
}
