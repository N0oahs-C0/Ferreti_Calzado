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
    public partial class FmrVentas : Form
    {
        MVentas mv;
        public static Ventas ventas = new Ventas(0, 0);
        int fila = 0, col = 0;
        public FmrVentas()
        {
            InitializeComponent();
            mv = new MVentas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ventas.Id = -1;
            FmrVentasA fma = new FmrVentasA();
            fma.ShowDialog();
            Actualizar();
        }

        private void dgtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventas.Id = int.Parse(dgtVentas.Rows[fila].Cells[0].Value.ToString());
            ventas.Fkpedido = int.Parse(dgtVentas.Rows[fila].Cells[0].Value.ToString());
            switch (col)
            {
                case 3:
                    {
                        FmrVentasA fa = new FmrVentasA();
                        fa.ShowDialog();
                        Actualizar();
                    } break;
                case 4:
                    {
                        mv.Borrar(ventas);
                        Actualizar();
                    } break;
                default:
                    break;
            }
        }

        private void dgtVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mv.Mostrar(dgtVentas, txtBuscar.Text);
        }
    }
}
