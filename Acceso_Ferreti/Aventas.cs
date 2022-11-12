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
    public class Aventas
    {
        Base b = new Base("localhost", "root", "", "ferreti", 3306);
        public void Borrar(Ventas Entidad)
        {
            b.Comando(string.Format("delete from ventas where id = {0}",
               Entidad.Id));
        }
        public void Guardar(Ventas Entidad)
        {
            b.Comando(string.Format("call  P_InsertVentas({0},{1})",
                Entidad.Id, Entidad.Fkpedido));
        }
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call p_showventas('%{0}%')",
                filtro), "ventas");
        }
    }
}
