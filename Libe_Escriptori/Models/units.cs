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
    
    public partial class units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public units()
        {
            this.attendance = new HashSet<attendance>();
            this.students = new HashSet<students>();
        }
    
        public int id { get; set; }
        public string abreviation { get; set; }
        public string name { get; set; }
        public int total_hours { get; set; }
        public int module_id { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> created_timestamp { get; set; }
        public Nullable<System.DateTime> updated_timestamp { get; set; }
        public Nullable<System.DateTime> deleted_timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attendance> attendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students> students { get; set; }
        public virtual modules modules { get; set; }
    }
}
