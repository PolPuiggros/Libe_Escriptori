﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libe_Escriptori.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class libeEntities : DbContext
    {
        public libeEntities()
            : base("name=libeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<attendance> attendance { get; set; }
        public virtual DbSet<attendance_status> attendance_status { get; set; }
        public virtual DbSet<calendars> calendars { get; set; }
        public virtual DbSet<center_information> center_information { get; set; }
        public virtual DbSet<holiday_type> holiday_type { get; set; }
        public virtual DbSet<holidays> holidays { get; set; }
        public virtual DbSet<justification_status> justification_status { get; set; }
        public virtual DbSet<justifications> justifications { get; set; }
        public virtual DbSet<lessons> lessons { get; set; }
        public virtual DbSet<logs> logs { get; set; }
        public virtual DbSet<schedules> schedules { get; set; }
        public virtual DbSet<user_type> user_type { get; set; }
        public virtual DbSet<validable_zones> validable_zones { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<students> students { get; set; }
        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<profesors> profesors { get; set; }
        public virtual DbSet<units> units { get; set; }
        public virtual DbSet<classrooms> classrooms { get; set; }
        public virtual DbSet<courses> courses { get; set; }
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<modules> modules { get; set; }
    }
}
