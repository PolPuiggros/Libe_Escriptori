using System;
using System.Collections.Generic;
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
    }
}
