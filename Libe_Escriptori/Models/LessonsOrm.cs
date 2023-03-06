using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models
{
    public static class LessonsOrm
    {
        public static List<lessons> Select()
        {
            List<lessons> _lessons = Orm.db.lessons.ToList();
            return _lessons;
        }
    }
}
