using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YummyAdmindWasm.Models;

namespace YummyAdminWasm.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int categoriaGlobalId { get; set; } // Java
        public CategoriaGlobal categoriaGlobal { get; set; }
    }
}