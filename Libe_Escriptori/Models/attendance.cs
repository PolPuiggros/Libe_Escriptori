//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class attendance
    {
        public int id { get; set; }
        public string status { get; set; }
        public System.DateTime lesson_datetime { get; set; }
        public int unit_id { get; set; }
        public int lesson_id { get; set; }
        public int student_id { get; set; }
        public Nullable<int> justification_id { get; set; }
    
        public virtual attendance_status attendance_status { get; set; }
        public virtual justifications justifications { get; set; }
        public virtual units units { get; set; }
        public virtual students students { get; set; }
        public virtual lessons lessons { get; set; }
    }
}
