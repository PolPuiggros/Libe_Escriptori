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
    
    public partial class departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public departments()
        {
            this.profesors1 = new HashSet<profesors>();
            this.courses = new HashSet<courses>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int profesor_in_charge_id { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> created_timestamp { get; set; }
        public Nullable<System.DateTime> updated_timestamp { get; set; }
        public Nullable<System.DateTime> deleted_timestamp { get; set; }
    
        public virtual profesors profesors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<profesors> profesors1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses> courses { get; set; }
    }
}
