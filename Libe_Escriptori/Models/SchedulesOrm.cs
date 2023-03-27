using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static schedules SelectSchedule(int scheduleId)
        {
            schedules _schedule = Orm.db.schedules
                                    .Where(schedule => schedule.id == scheduleId)
                                    .FirstOrDefault();

            return _schedule;
        }

        public static string Insert(schedules _schedule)
        {
            string message = "";
            try
            {
                Orm.db.schedules.Add(_schedule);
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

