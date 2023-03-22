using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace Libe_Escriptori.Models.Centre
{
    public static class CalendariOrm
    {
        public static List<holidays> Select()
        {
            List<holidays> result = Orm.db.holidays
                .ToList();
            return result;
        }

        public static calendars SelectCalendari()
        {
            return Orm.db.calendars.FirstOrDefault();
        }

        public static string UpdateType(int v, DateTime selected)
        {
            string missatges = "";
            try
            {
                holidays holi = Orm.db.holidays
                .Where(h => h.festive_day == selected)
                .FirstOrDefault();
                holi.type = v;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }

        public static string Insert(holidays holiday)
        {
            string missatges = "";
            try
            {
                holidays holi = Orm.db.holidays.Add(holiday);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }

        public static string Delete(DateTime daySelected)
        {
            string missatges = "";
            try
            {
                holidays holi = Orm.db.holidays.Where(h => h.festive_day == daySelected).FirstOrDefault();
                Orm.db.holidays.Remove(holi);
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }

        public static string UpdateEndingDate(DateTime date)
        {
            string missatges = "";
            try
            {
                calendars clr = Orm.db.calendars.FirstOrDefault();
                clr.ending_date = date;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }
        public static string UpdateStartingDate(DateTime date)
        {
            string missatges = "";
            try
            {
                calendars clr = Orm.db.calendars.FirstOrDefault();
                clr.starting_date = date;
                Orm.db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlException = (SqlException)e.InnerException.InnerException;
                missatges = Orm.MissatgeError(sqlException);
            }
            return missatges;
        }
    }
}
