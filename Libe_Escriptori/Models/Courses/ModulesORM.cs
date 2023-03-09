using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Courses
{
    public static class ModulesORM
    {
        public static List<modules> Select(int id)
        {
            List<modules> modules = Orm.db.courses
                .Where(c => c.id == id)
                .SelectMany(c => c.modules)
                .ToList();

            return modules;

        }

        public static modules SelectModule(int id)
        {
            modules _modules = Orm.db.modules
                .Where(c => c.id == id)
                .First();
            return _modules;
        }

        public static List<modules> Select()
        {
            List<modules> modules = Orm.db.modules
                .Where(c => c.active == true)
                .ToList();

            return modules;
        }

        public static void Delete(modules _modules)
        {
            _modules = Orm.db.modules
                .Where(c => c.id == _modules.id)
                .First();
            _modules.active = false;
            _modules.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }

        public static void Update(modules _modules) { 
        }

        

    }
}
