using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatos
{
    public class CompraInsumo : IConexion
    {
        Base b = new Base("localhost","root","","ferreti");

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("Call Delete p_deletecomprainsumos({0})",Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(String.Format("Call Delete P_InsertCompraInsumos({0},{1},{2})", Entidad.Id, Entidad.Fkinsumo, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(String.Format("Call p_showcomprainsumos('%{0}%')",Filtro),"compra_insumos");
        }
    }
}
