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
    public class CompraInsumo 
    {
        Base b = new Base("localhost","root","","ferreti", 3306);

        public void Borrar(ECompraInsumo Entidad)
        {
            b.Comando(string.Format("Call Delete p_deletecomprainsumos({0})",Entidad.Id));
        }

        public void Guardar(ECompraInsumo Entidad)
        {
            b.Comando(string.Format("Call Delete P_InsertCompraInsumos({0},{1},{2})", Entidad.Id, Entidad.Fkinsumo, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call p_showcomprainsumos('%{0}%')",Filtro),"compra_insumos");
        }
    }
}
