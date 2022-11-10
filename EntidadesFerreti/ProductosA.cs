using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class ProductosA
    {
        public ProductosA(int id, int cantidad, int fkpedido, string fecha_hora)
        {
            Id = id;
            Cantidad = cantidad;
            Fkpedido = fkpedido;
        }

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int Fkpedido { get; set; }
    }
}
