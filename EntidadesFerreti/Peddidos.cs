using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class Peddidos
    {
        public Peddidos(int id, string cliente, int cantidad)
        {
            Id = id;
            Cliente = cliente;
            Cantidad = cantidad;
        }

        public int Id { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
    }
}
