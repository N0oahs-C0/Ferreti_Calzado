using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Ferreti;
using Crud;
namespace ManejadorFerreti
{
    public class ManejadorAlmacenInsumos : IManejador
    {
        AlmacenInsumo A = new AlmacenInsumo();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!!","Seguro que quiere borrar?",MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                A.Borrar(Entidad);
            }
        }

        public void Exportar(ComboBox caja)
        {
            throw new NotImplementedException();
        }

        public void guardar(dynamic Entidad)
        {
            A.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Rows.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = A.Mostrar(filtro).Tables["almacen_insumos"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
