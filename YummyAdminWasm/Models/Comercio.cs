using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YummyAdminWasm.Models
{
    public class Comercio
    {
        public int id {get; set;}       
        public string? nombre { get; set; }
        public string? telefono { get; set; }
        public string? email { get; set; }
        public string? direccion { get; set; }
        public string? horario { get; set; }
        public string? imagen { get; set; }
        public string? logo { get; set; }
        public int? categoriaId { get; set; }

        public Categoria? categoria {get; set;}  
    }
}