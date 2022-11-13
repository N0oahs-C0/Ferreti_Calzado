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
    public class MProductosT
    {
        AproductoT apt = new AproductoT();
        Grafico g = new Grafico();
        public void Borrar(ProductosT Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de borrar?: {0}", Entidad.Productos)), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                apt.Borrar(Entidad);
        }

        public void Guardar(ProductosT Entidad)
        {
            apt.Guardar(Entidad);
            g.MensajeAlerta("Producto guardado/terminado con exito", "!Atención",
                    MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = apt.Mostrar(filtro).Tables["productos_terminados"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
