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
    public class AproductoT
    {
        Base b = new Base("localhost", "root", "", "ferreti", 3306);
        public void Borrar(ProductosT Entidad)
        {
            b.Comando(string.Format("delete from productos_terminados where id = {0}",
               Entidad.Id));
        }
        public void Guardar(ProductosT Entidad)
        {
            b.Comando(string.Format("call  P_InsertProductoTerminado({0},'{1}',{2})",
                Entidad.Id, Entidad.Productos, Entidad.Cantidad));
        }
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call p_showproductoterminado('%{0}%')",
                filtro), "productos_terminados");
        }
    }
}
