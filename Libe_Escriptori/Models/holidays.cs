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
    
    public partial class holidays
    {
        public System.DateTime festive_day { get; set; }
        public int calendar_id { get; set; }
        public Nullable<int> type { get; set; }
    
        public virtual calendars calendars { get; set; }
        public virtual holiday_type holiday_type { get; set; }
    }
}
