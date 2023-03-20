using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class LogsOrm
    {
        public static List<logs> Select()
        {
            List<logs> list = new List<logs>();
            list = Orm.db.logs.ToList();

            return list;
        }

        public static string SelectSubjecte(int idCanvi, string tableChange)
        { 
            switch (tableChange)
            {
                case "PROFESORS":
                    return Orm.db.profesors.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "STUDENTS":
                    return Orm.db.students.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "VALIDABLE ZONES":
                    return Orm.db.validable_zones.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "CLASSROOMS":
                    return Orm.db.classrooms.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "GROUPS":
                    groups gr = Orm.db.groups.Where(p => p.id == idCanvi).FirstOrDefault();
                    string cursNom = Orm.db.courses.Where(c => c.id == gr.course_id).FirstOrDefault().name;
                    return cursNom + gr.grade + gr.group_letter;
                case "COURSES":
                    return Orm.db.courses.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "MODULES":
                    return Orm.db.modules.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "DEPARTMENTS":
                    return Orm.db.departments.Where(p => p.id == idCanvi).FirstOrDefault().name;
                case "UNITS":
                    return Orm.db.units.Where(p => p.id == idCanvi).FirstOrDefault().name;
                default:
                    return "undefined";
            }
        }
    }
}
