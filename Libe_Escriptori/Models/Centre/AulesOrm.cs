using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Centre
{
    public static class AulesOrm
    {
        public static List<classrooms> Select(int validableZoneId, bool state)
        {
           List<classrooms> _classrooms = Orm.db.classrooms
            .Where(c => c.validable_zone_id == validableZoneId && c.active == state)
            .ToList();

            return _classrooms;
        }

        public static List<classrooms> Select(bool state)
        {
            List<classrooms> _classrooms = Orm.db.classrooms
            .Where(c => c.active == state)
            .ToList();

            return _classrooms;
        }

        public static void Insert(classrooms aula)
        {
            Orm.db.classrooms.Add(aula);
            Orm.db.SaveChanges();
        }

        public static string Delete(classrooms aula)
        {
            string missatges = "";
            try
            {
                aula = Orm.db.classrooms
                    .Where(d => d.id == aula.id)
                    .FirstOrDefault();
                aula.active = false;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }
    }
}
