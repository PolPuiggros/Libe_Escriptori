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
    
    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            this.classrooms = new HashSet<classrooms>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type { get; set; }
        public bool active { get; set; }
    
        public virtual user_type user_type { get; set; }
        public virtual profesors profesors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<classrooms> classrooms { get; set; }
        public virtual students students { get; set; }
    }
}
