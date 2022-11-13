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
    public class ManejadorCompraInsumo : IManejador
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

        public void guardar(dynamic Entidad)
        {
            Ci.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Rows.Clear(); //error
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Ci.Mostrar(filtro).Tables["compra_insumos"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }

        public void ExportarInsumo(ComboBox caja) 
        {
            caja.DataSource = Ai.Mostrar("").Tables["almacen_insumos"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "id";
        }

        public void Exportar(ComboBox caja)
        {
            throw new NotImplementedException();
        }
    }
}
