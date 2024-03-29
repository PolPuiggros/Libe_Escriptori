﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        public static List<modules> SelectAll(courses _courses)
        {
            List<modules> modules;
            if (_courses != null)
            {
                List<int> ids = new List<int>();
                foreach (var module in _courses.modules)
                {
                    ids.Add(module.id);
                }
            
                 modules = Orm.db.modules
                    .Where(c => c.active == true && !ids.Contains(c.id))
                    .ToList();
            }
            else
            {
                modules = Orm.db.modules.ToList();
            }
            
            return modules;
        }
        public static List<modules> Select()
        {
            List<modules> modules = Orm.db.modules
                .Where(c => c.active == true)
                .ToList();

            return modules;
        }

        public static string Delete(modules _modules)
        {
            string message = "";
            try
            {
                _modules = Orm.db.modules
                    .Where(c => c.id == _modules.id)
                    .First();
                _modules.active = false;
                _modules.deleted_timestamp = DateTime.Now;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string Update(modules _modules) {
            string message = "";
            try
            {
                modules module = Orm.db.modules
                    .Where(c => c.id == _modules.id)
                    .First();

                module.code = _modules.code;
                module.name = _modules.name;
                module.total_hours = _modules.total_hours;
                module.active = _modules.active;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                message = Orm.MissatgeError(sqlException);
            }
            return message;
        }

        public static string InsertWithUnits(modules _modules, List<units> listUnits)
        {
            string message = "";
            try
            {
                Orm.db.modules.Add(_modules);
                Orm.db.SaveChanges();
                var lastModules = Orm.db.modules
                   .ToList()
                   .Last();
                foreach (units u in listUnits)
                {
                    u.module_id = lastModules.id;
                    UnitsORM.Insert(u);
                }
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
