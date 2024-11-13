namespace YummyAdminWasm.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }

        public EstadoProducto estado { get; set; }

        public string imagen { get; set; }
        public int categoriaProductoId { get; set; }
        public int comercioId { get; set; }

        public Comercio comercio { get; set; }

        public CategoriaProducto categoriaProducto { get; set; }



        public enum EstadoProducto
        {
            ACTIVO,
            INACTIVO
        }
    }
}
