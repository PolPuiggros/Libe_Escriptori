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
    
    public partial class validable_zones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public validable_zones()
        {
            this.classrooms = new HashSet<classrooms>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int radius { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> created_timestamp { get; set; }
        public Nullable<System.DateTime> updated_timestamp { get; set; }
        public Nullable<System.DateTime> deleted_timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<classrooms> classrooms { get; set; }
    }
}
