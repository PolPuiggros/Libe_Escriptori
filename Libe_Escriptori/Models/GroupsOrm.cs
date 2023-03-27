using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static List<groups> SelectFromCourse(int idCourse)
        {
            List<groups> _groups = Orm.db.groups
               .Where(group => group.active == true && group.course_id == idCourse)
               .ToList();

            return _groups;
        }

        public static string Insert(groups _group)
        {
            string message = "";
            try
            {
                Orm.db.groups.Add(_group);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Delete(groups _group)
        {
            string message = "";
            try
            {
                _group = Orm.db.groups
                    .Where(group => group.id == _group.id)
                    .FirstOrDefault();
                _group.active = false;
                _group.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;

        }
        public static string DeleteGroup(groups _group)
        {
            string message = "";
            try
            {
                Orm.db.groups.Remove(_group);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Update(groups _groups)
        {
            string message = "";
            try
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
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }
    }
}
