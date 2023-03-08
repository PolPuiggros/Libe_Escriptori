using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class LessonsOrm
    {
        public static List<lessons> Select(int scheduleId)
        {
            List<lessons> _lessons = Orm.db.lessons
                                            .Where(lesson => lesson.schedule_id == scheduleId)
                                            .ToList();
            return _lessons;
        }

        public static List<lessons> SelectDayLessons(string weekday)
        {
            List<lessons> _lessons = Orm.db.lessons
                                            .Where(lesson => lesson.weekday == weekday)
                                            .ToList();
            return _lessons;
        }

        public static List<TimeSpan> SelectHours()
        {
            List<TimeSpan> _hours = Orm.db.lessons
                                        .Select(lesson => lesson.starting_hour).Distinct()
                                        .ToList();
            return _hours;
        }

        public static List<lessons> SelectLessonsAtHour(TimeSpan hour)
        {
            List<lessons> _lessons = Orm.db.lessons
                                            .Where(lesson => lesson.starting_hour == hour)
                                            .ToList();
            return _lessons;
        }
    }
}
