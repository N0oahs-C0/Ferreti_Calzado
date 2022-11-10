using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class ProductosT
    {
        public ProductosT(int id, string productos, int cantidad)
        {
            Id = id;
            Productos = productos;
            Cantidad = cantidad;
        }

        public int Id { get; set; }
        public string Productos { get; set; }
        public int Cantidad { get; set; }
    }
}
