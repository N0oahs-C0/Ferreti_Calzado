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
    public class MProductosA
    {
        AproductoA apa = new AproductoA();
        Grafico g = new Grafico();
        public void Borrar(ProductosA Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de borrar?: {0}", Entidad.Id)), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                apa.Borrar(Entidad);
        }

        public void Guardar(ProductosA Entidad)
        {
            apa.Guardar(Entidad);
            g.MensajeAlerta("Producto Apartado con exito", "!Atención",
                    MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = apa.Mostrar(filtro).Tables["productos_apartados"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        /*public void ExtraerPedido(ComboBox caja)
        {
            caja.DataSource = ap.Mostrar("").Tables["Pedidos"];
            caja.DisplayMember = "Cliente";
            caja.ValueMember = "id";
        }*/
    }
}
