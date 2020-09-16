using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testAppRepo.Models
{
    public class CrudContext : DbContext
    {
        public DbSet<TIPOPRODUCTO> TipoProducto { get; set; }
    }
}