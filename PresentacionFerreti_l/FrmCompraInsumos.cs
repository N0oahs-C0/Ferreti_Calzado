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
namespace PresentacionFerreti_l
{
    public partial class FrmCompraInsumos : Form
    {
        public static ECompraInsumo Ec = new ECompraInsumo(0, 0, 0, 0);
        int Fila = 0, Columna = 0;
        public static string FkInsumo, fkPedido;

        ManejadorCompraInsumo Mci;
        public FrmCompraInsumos()
        {
            InitializeComponent();
            Mci = new ManejadorCompraInsumo();
            
        }

        private void dtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            Columna = e.ColumnIndex;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Ec.Id = -1;
            FrmAddCompraInsumos frm = new FrmAddCompraInsumos();
            frm.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mci.Mostrar(dtgMostrar, TxtBuscar.Text);
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fkPedido = dtgMostrar.Rows[Fila].Cells[1].Value.ToString();
            FkInsumo = dtgMostrar.Rows[Fila].Cells[2].Value.ToString();
            Ec.Cantidad = int.Parse(dtgMostrar.Rows[Fila].Cells[3].Value.ToString());
            switch (Columna)
            {
                case 5: { FrmAddCompraInsumos frmAddCompraInsumos = new FrmAddCompraInsumos();
                        frmAddCompraInsumos.ShowDialog();
                    } break;
                case 6:{ Mci.Borrar(Ec.Id); } break;
                default:
                    break;
            }
        }
    }
}
