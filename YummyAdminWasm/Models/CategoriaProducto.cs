using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YummyAdminWasm.Models
{
    public class CategoriaProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int comercioId { get; set; } // Java
        public Comercio comercio { get; set; }
    }
}