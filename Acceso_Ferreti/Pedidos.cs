using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesFerreti;

namespace AccesoDatos
{
    public class Pedidos : IConexion
    {
        Base b = new Base("localhost", "root", "", "ferreti");

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("Call Deletepedido({0})",Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(String.Format("Call InsertPedido({0})", Entidad.Id));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowPedido('%{0}%')",Filtro),"pedidos");
        }
    }
}
