using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static lessons SelectFromAttributes(string day,string hour,string module,int scheduleId)
        {
            //int _hour = int.Parse(hour);
            
            TimeSpan time = TimeSpan.Parse(hour);
            lessons _lesson = Orm.db.lessons
                .Where(lesson => lesson.schedule_id == scheduleId && lesson.starting_hour.Equals(time) && lesson.weekday == day)
                .FirstOrDefault();
            return _lesson;
        }

        public static List<TimeSpan> SelectHours()
        {
            List<TimeSpan> _hours = Orm.db.lessons
                                        .Select(lesson => lesson.starting_hour).Distinct()
                                        .ToList();
            return _hours;
        }

        public static List<lessons> SelectLessonsAtHour(TimeSpan hour, int scheduleId)
        {
            List<lessons> _lessons = Orm.db.lessons
                                            .Where(lesson => lesson.starting_hour == hour && lesson.schedule_id == scheduleId)
                                            .ToList();
            return _lessons;
        }

        public static void Update(lessons _lesson)
        {
            lessons updateLesson = Orm.db.lessons
                                .Where(lesson => lesson.id == _lesson.id)
                                .ToList()
                                .FirstOrDefault();

            updateLesson.module_id = _lesson.module_id;
            Orm.db.SaveChanges();
        }

        public static lessons SelectLessonsAtDayHour(TimeSpan hour, string weekday, int scheduleId)
        {
            lessons _lesson = Orm.db.lessons
                                .Where(lesson => lesson.starting_hour == hour && lesson.weekday == weekday && lesson.schedule_id == scheduleId)
                                .ToList()
                                .FirstOrDefault();


            return _lesson;
        }

        public static void Insert(lessons _lesson)
        {
            Orm.db.lessons.Add(_lesson);
            Orm.db.SaveChanges();
        }
    }
}
