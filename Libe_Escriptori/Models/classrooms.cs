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
    
    public partial class classrooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public classrooms()
        {
            this.lessons = new HashSet<lessons>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int validable_zone_id { get; set; }
        public int user_id { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> created_timestamp { get; set; }
        public Nullable<System.DateTime> updated_timestamp { get; set; }
        public Nullable<System.DateTime> deleted_timesatmp { get; set; }
    
        public virtual users users { get; set; }
        public virtual validable_zones validable_zones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lessons> lessons { get; set; }
    }
}
