using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Centre
{
    public static class ZonesValidablesOrm
    {
        public static List<validable_zones> Select(bool active)
        {
            List<validable_zones> _validables = null;
            try
            {
                _validables = Orm.db.validable_zones
                .Where(s => s.active == active)
                .ToList();
            }
            catch (SqlException e)
            {
                Orm.MissatgeError(e);
            }
            

            return _validables;
        }
        public static string Insert(validable_zones zona)
        {
            String missatges = "";
            try
            {
                Orm.db.validable_zones.Add(zona);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }
        public static string Delete(validable_zones vz)
        {
            string missatges = "";
            try
            {
                vz = Orm.db.validable_zones
                    .Where(v => v.id == vz.id)
                    .FirstOrDefault();

                vz.active = false;
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
