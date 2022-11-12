using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFerreti
{
    public class EAlmacenInsumo
    {
        public EAlmacenInsumo(int id, string nombre, int cantidad, int costo, int cantidadxpar)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Costo = costo;
            Cantidadxpar = cantidadxpar;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Costo { get; set; }
        public int Cantidadxpar { get; set; }

    }
}
