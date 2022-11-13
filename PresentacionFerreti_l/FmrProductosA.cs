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
    public partial class FmrProductosA : Form
    {
        MProductosA ma;
        public static ProductosA entidad = new ProductosA(0,0,0);
        int fila = 0, col = 0;
        public FmrProductosA()
        {
            InitializeComponent();
            ma = new MProductosA();
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
            FmrProductosAA fma = new FmrProductosAA();
            fma.ShowDialog();
            Actualizar();
        }

        private void dgtProductosA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtProductosA.Rows[fila].Cells[0].Value.ToString());
            entidad.Cantidad = int.Parse(dgtProductosA.Rows[fila].Cells[1].Value.ToString());
            entidad.Fkpedido = int.Parse(dgtProductosA.Rows[fila].Cells[2].Value.ToString());
            switch (col)
            {
                case 4:
                    {
                        FmrProductosAA fa = new FmrProductosAA();
                        fa.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        ma.Borrar(entidad);
                        Actualizar();
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgtProductosA_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
        void Actualizar()
        {
            ma.Mostrar(dgtProductosA, txtBuscar.Text);
        }
    }
}
