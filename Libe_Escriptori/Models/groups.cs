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
    
    public partial class groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public groups()
        {
            this.students = new HashSet<students>();
        }
    
        public int id { get; set; }
        public int grade { get; set; }
        public string group_letter { get; set; }
        public int course_id { get; set; }
        public int tutor_id { get; set; }
        public int schedule_id { get; set; }
    
        public virtual courses courses { get; set; }
        public virtual profesors profesors { get; set; }
        public virtual schedules schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students> students { get; set; }
    }
}