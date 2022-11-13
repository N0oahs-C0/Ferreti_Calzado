using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using EntidadesFerreti;
using Acceso_Ferreti;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorFerreti
{
    public class MVentas
    {
        Pedidos pe = new Pedidos();
        Aventas av = new Aventas();
        Grafico g = new Grafico();
        public void Borrar(Ventas Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de borrar?: {0}", Entidad.Id)), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                av.Borrar(Entidad);
        }

        public void Guardar(Ventas Entidad)
        {
            av.Guardar(Entidad);
            g.MensajeAlerta("Venta Realizada con exito con exito", "!Atención",
                    MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = av.Mostrar(filtro).Tables["ventas"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        public void ExtraerPedido(ComboBox caja)
        {
            caja.DataSource = pe.Mostrar("").Tables["Pedidos"];
            caja.DisplayMember = "Cliente";
            caja.ValueMember = "id";
        }
    }
}
