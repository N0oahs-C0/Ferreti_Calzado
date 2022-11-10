using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class Ventas
    {
        public Ventas(int id, int fkpedido)
        {
            Id = id;
            Fkpedido = fkpedido;
        }

        public int Id { get; set; }
        public int Fkpedido { get; set; }
    }
}
