using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori.Models.Courses
{
    public static class UnitsORM
    {
        public static List<units> Select(int id)
        {
            List<units> units = Orm.db.modules
                .Where(c => c.id == id)
                .SelectMany(c => c.units)
                .ToList();

            return units;

        }

        public static units Select(string name)
        {
            units _units = Orm.db.units
                .Where(c => c.active == true && c.name == name)
                .FirstOrDefault();

            return _units;
        }

        public static void Delete(units _units)
        {
            _units = Orm.db.units
                .Where(c => c.id == _units.id)
                .First();
            _units.active = false;
            _units.deleted_timestamp = DateTime.Now;
            Orm.db.SaveChanges();
        }

        public static void Update(units _units) {
            units unit = Orm.db.units
                .Where(c => c.id == _units.id)
                .First();

            unit.abreviation = _units.abreviation;
            unit.name = _units.name;
            unit.total_hours = _units.total_hours;
            unit.active = _units.active;
            unit.module_id = _units.module_id;

            Orm.db.SaveChanges();
        }

        public static void Insert(units _units)
        {
            Orm.db.units.Add(_units);
            Orm.db.SaveChanges();
        }

    }
}
