using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class SchedulesOrm
    {
        public static List<schedules> Select()
        {
            List<schedules> _schedules = Orm.db.schedules.ToList();
            return _schedules;
        }

        public static void Insert(schedules _schedule)
        {
            Orm.db.schedules.Add(_schedule);
            Orm.db.SaveChanges();
        }

    }



}

