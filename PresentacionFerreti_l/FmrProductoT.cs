using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesFerreti;
using ManejadorFerreti;
using Acceso_Ferreti;

namespace PresentacionFerreti_l
{
    public partial class FmrProductoT : Form
    {
        MProductosT mt;
        public static ProductosT entidad = new ProductosT(0, "", 0);
        int fila = 0, col = 0;
        public FmrProductoT()
        {
            InitializeComponent();
            mt = new MProductosT();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FmrProductosTA fma = new FmrProductosTA();
            fma.ShowDialog();
            Actualizar();
        }

        private void dgtProductosT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtProductosT.Rows[fila].Cells[0].Value.ToString());
            entidad.Productos = dgtProductosT.Rows[fila].Cells[1].Value.ToString();
            entidad.Cantidad = int.Parse(dgtProductosT.Rows[fila].Cells[2].Value.ToString());
            switch (col)
            {
                case 3:
                    {
                        FmrProductosTA fa = new FmrProductosTA();
                        fa.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mt.Borrar(entidad);
                        Actualizar();
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgtProductosT_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
        void Actualizar()
        {
            mt.Mostrar(dgtProductosT, txtBuscar.Text);
        }
    }
}
