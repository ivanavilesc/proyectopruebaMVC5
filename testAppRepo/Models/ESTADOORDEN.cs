//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testAppRepo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTADOORDEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADOORDEN()
        {
            this.DETALLEORDEN = new HashSet<DETALLEORDEN>();
        }
    
        public decimal IDESTADO { get; set; }
        public string DESCESTORDEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLEORDEN> DETALLEORDEN { get; set; }
    }
}
