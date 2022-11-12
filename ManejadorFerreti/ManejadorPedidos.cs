using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using EntidadesFerreti;
using crud;
using System.Drawing;

namespace ManejadorFerreti
{
    public class ManejadorPedidos : IManejador
    {
        Pedidos p = new Pedidos();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!",
                "Estás seguro de borrar?",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            p.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void guardar(dynamic Entidad)
        {
            p.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Rows.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = p.Mostrar(filtro).Tables["pedidos"];
            tabla.Columns.Insert(4,g.Boton("Editar",Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
