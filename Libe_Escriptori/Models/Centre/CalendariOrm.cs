using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Centre
{
    public static class CalendariOrm
    {
        internal static List<holidays> Select(int tipus)
        {
            List<holidays> result = Orm.db.holidays
                .Where(d => d.type == tipus)
                .ToList();
            return result;
        }
    }
}
