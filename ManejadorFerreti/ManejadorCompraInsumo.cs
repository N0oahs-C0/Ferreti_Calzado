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
    public class ManejadorCompraInsumo:IManejador
    {
        CompraInsumo Ci = new CompraInsumo();
        Grafico g = new Grafico();
        AlmacenInsumo Ai = new AlmacenInsumo();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!!", "Seguro que quiere borrar?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Ci.Borrar(Entidad);
            }
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void guardar(dynamic Entidad)
        {
            Ci.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Rows.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Ci.Mostrar(filtro).Tables["compra_insumos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
        public void ExportarInsumos(ComboBox Caja) {
            Caja.DataSource = Ai.Mostrar("").Tables["almacen_insumos"];
            Caja.DisplayMember = "nombre";
            Caja.ValueMember = "Id";
        
        }
    }
}
