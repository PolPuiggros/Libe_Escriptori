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
            List<groups> _groups = Orm.db.groups
                .Where(group => group.active == true)
                .ToList();

            return _groups;
        }

        public static groups SelectGroup(int id_group)
        {
            groups _group = Orm.db.groups
                .Where(group => group.id == id_group)
                .FirstOrDefault();

            return _group;
        }

        public static void Insert(groups _group)
        {
            Orm.db.groups.Add(_group);
            Orm.db.SaveChanges();
        }

        public static void Delete(groups _group)
        {
            _group = Orm.db.groups
                .Where(group => group.id == _group.id)
                .FirstOrDefault();
            _group.active = false;
            _group.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();

        }
        public static void DeleteGroup(groups _group)
        {
            Orm.db.groups.Remove(_group);
            Orm.db.SaveChanges();
        }

        public static void Update(groups _groups)
        {
            groups _group = Orm.db.groups
                            .Where(group => group.id == _groups.id)
                            .FirstOrDefault();

            _group.grade = _groups.grade;
            _group.group_letter = _groups.group_letter;
            _group.course_id = _groups.course_id;
            _group.tutor_id = _groups.tutor_id;
            _group.classroom_id = _groups.classroom_id;
            Orm.db.SaveChanges();
        }
    }
}
