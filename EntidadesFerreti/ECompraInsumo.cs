using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class ECompraInsumo
    {
        public ECompraInsumo(int id, int fkPedido, int fkinsumo, int cantidad)
        {
            Id = id;
            Fkinsumo = fkinsumo;
            Cantidad = cantidad;
            FkPedido = fkPedido;
        }

        public int Id { get; set; }
        public int FkPedido { get; set; }
        public int Fkinsumo { get; set; }
        public int Cantidad { get; set; }
    }
}
