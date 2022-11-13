using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorFerreti;
using EntidadesFerreti;

namespace PresentacionFerreti_l
{
    public partial class FrmPedidos : Form
    {
        int Fila = 0, columna = 0;
        ManejadorPedidos Mp;
        public static Peddidos p = new Peddidos(0,"",0);
        public FrmPedidos()
        {
            InitializeComponent();
            Mp = new ManejadorPedidos();
        }
        void Actualizar() 
        {
            Mp.Mostrar(dtgMostrar,TxtBuscar.Text);
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            p.Id = -1;
            FrmAddPedidos frmAddPedidos = new FrmAddPedidos();
            frmAddPedidos.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p.Id =int.Parse(dtgMostrar.Rows[Fila].Cells[0].Value.ToString());
            p.Cliente = dtgMostrar.Rows[Fila].Cells[1].Value.ToString();
            p.Cantidad = int.Parse(dtgMostrar.Rows[Fila].Cells[2].Value.ToString());
            switch (columna)
            {
                case 4: {
                    FrmAddPedidos frmAddPedidos = new FrmAddPedidos();
                        frmAddPedidos.ShowDialog();
                        Actualizar();
                    } break;
                case 5: { Mp.Borrar(p.Id); } break;
                default:
                    break;
            }
        }
    }
}
