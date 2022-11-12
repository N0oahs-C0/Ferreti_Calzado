using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesFerreti;
using ConectarBd;

namespace AccesoDatos
{
    public class AlmacenInsumo : IConexion
    {
        Base b = new Base("localhost","root","","ferreti");
        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("Call DeleteAlmacen_Insumos({0})",Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertAlmacen_Insumos({0},{1},'{2}',{3},{4})", Entidad.Id,Entidad.Nombre,
                Entidad.Cantidad,Entidad.Costo,Entidad.Cantidadxpar));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call showAlmacen_Insumos('%{0}%')",Filtro),"almacen_insumos");
        }
    }
}
