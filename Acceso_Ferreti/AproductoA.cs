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
    public class AproductoA
    {
        Base b = new Base("localhost", "root", "", "ferreti", 3306);
        public void Borrar(ProductosA Entidad)
        {
            b.Comando(string.Format("delete from productos_apartados where id = {0}",
               Entidad.Id));
        }
        public void Guardar(ProductosA Entidad)
        {
            b.Comando(string.Format("call  P_InsertProductoApartado({0},{1},{2})",
                Entidad.Id, Entidad.Cantidad,Entidad.Fkpedido));
        }
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call p_showproductoapartado('%{0}%')",
                filtro), "productos_apartados");
        }
    }
}
