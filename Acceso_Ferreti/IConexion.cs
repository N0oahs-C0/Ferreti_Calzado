using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Ferreti
{
    internal interface IConexion
    {
        void Guardar(dynamic Entidad);
        DataSet Mostrar(string Filtro);
        void Borrar(dynamic Entidad);
    }
}
