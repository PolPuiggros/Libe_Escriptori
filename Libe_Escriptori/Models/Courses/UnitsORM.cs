using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static string Delete(units _units)
        {
            string message = "";
            try
            {
                _units = Orm.db.units
                    .Where(c => c.id == _units.id)
                    .First();
                _units.active = false;
                _units.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;

        }

        public static string Update(units _units) {
            string message = "";
            try
            {
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
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Insert(units _units)
        {
            string message = "";
            try
            {
                Orm.db.units.Add(_units);
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
