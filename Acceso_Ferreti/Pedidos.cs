using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesFerreti;

namespace Acceso_Ferreti
{
    public class Pedidos 
    {
        Base b = new Base("localhost", "root", "", "ferreti", 3306);

        public void Borrar(Peddidos Entidad)
        {
            b.Comando(string.Format("Call Deletepedido({0})", Entidad.Id));
        }

        public void Guardar(Peddidos Entidad)
        {
            b.Comando(string.Format("Call InsertPedido({0}, '{1}', {2})", Entidad.Id, Entidad.Cliente, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowPedidos('%{0}%')",Filtro),"pedidos");
        }
    }
}
