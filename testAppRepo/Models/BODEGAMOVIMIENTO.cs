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
    
    public partial class BODEGAMOVIMIENTO
    {
        public decimal IDMOVBODEGA { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<decimal> VALORPRODUCTO { get; set; }
        public decimal IDTIPOMOVIMIENTO { get; set; }
        public decimal IDINSUMO { get; set; }
    
        public virtual INSUMO INSUMO { get; set; }
        public virtual TIPOMOVBODEGA TIPOMOVBODEGA { get; set; }
    }
}
