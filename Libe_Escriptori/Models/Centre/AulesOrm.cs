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
        public static List<classrooms> Select(int validableZoneId)
        {
           List<classrooms> _classrooms = Orm.db.classrooms
            .Where(c => c.validable_zone_id == validableZoneId)
            .ToList();

            return _classrooms;
        }

        public static void Insert(classrooms aula)
        {

            Orm.db.classrooms.Add(aula);
            Orm.db.SaveChanges();
        }
    }
}
