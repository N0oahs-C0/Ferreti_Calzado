using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Ferreti;
using Crud;
using System.Drawing;

namespace ManejadorFerreti
{
    public class ManejadorPedidos : IManejador
    {
        Pedidos p = new Pedidos();
        Grafico g = new Grafico();
        AproductoT apt = new AproductoT();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!",
                "Estás seguro de borrar?",
                MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            p.Borrar(Entidad);
        }

        public void Exportar(ComboBox caja)
        {
            throw new NotImplementedException();
        }

        public void guardar(dynamic Entidad)
        {
            p.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Rows.Clear(); //error al darle en buscar mas de una vez
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = p.Mostrar(filtro).Tables["pedidos"];
            tabla.Columns.Insert(4, g.Boton("Editar",Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
        public void ExptraerCantidad(ComboBox caja)
        {
            caja.DataSource = apt.Mostrar("").Tables["productos_terminados"];
            caja.DisplayMember = "cantidad";
            caja.ValueMember = "id";
        }
    }
}
