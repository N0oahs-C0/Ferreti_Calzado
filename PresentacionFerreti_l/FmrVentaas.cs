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
    public partial class FmrVentaas : Form
    {
        MVentas mv;
        public static Ventas ventas = new Ventas(0, 0);
        //public static int Fkpedido;
        int fila = 0, col = 0;
        public FmrVentaas()
        {
            InitializeComponent();
            mv = new MVentas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventas.Id = -1;
            fmrVentasAA fma = new fmrVentasAA();
            fma.ShowDialog();
            Actualizar();
        }

        private void dgtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventas.Id = int.Parse(dgtVentas.Rows[fila].Cells[0].Value.ToString());
            ventas.Fkpedido = int.Parse(dgtVentas.Rows[fila].Cells[1].Value.ToString());
            switch (col)
            {
                case 3:
                    {
                         fmrVentasAA fa = new fmrVentasAA();
                        fa.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mv.Borrar(ventas);
                        Actualizar();
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgtVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Actualizar()
        {
            mv.Mostrar(dgtVentas, txtBuscar.Text);
        }
    }
}
