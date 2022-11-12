using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace Acceso_Ferreti
{
    public class Pedidos : IConexion
    {
        Base b = new Base("localhost", "root", "", "ferreti", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("Call Deletepedido({0})",Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("Call InsertPedido({0})", Entidad.Id));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowPedido('%{0}%')",Filtro),"pedidos");
        }
    }
}
