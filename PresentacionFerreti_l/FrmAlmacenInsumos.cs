using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesFerreti;
using ManejadorFerreti;
namespace PresentacionFerreti_l
{
    public partial class FrmAlmacenInsumos : Form
    {
        int fila = 0, columna = 0;
        static public EAlmacenInsumo Ea = new EAlmacenInsumo(0,"",0,0,0);
        ManejadorAlmacenInsumos Mai;
        public FrmAlmacenInsumos()
        {
            InitializeComponent();
            Mai = new ManejadorAlmacenInsumos();
        }
        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Ea.Id = -1;
            FrmAddInsumo frmAddInsumo = new FrmAddInsumo();
            frmAddInsumo.ShowDialog();
        }

        private void dtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Ea.Id = int.Parse(dtgMostrar.Rows[fila].Cells[0].Value.ToString());
            Ea.Nombre = dtgMostrar.Rows[fila].Cells[1].Value.ToString();
            Ea.Cantidad = int.Parse(dtgMostrar.Rows[fila].Cells[2].Value.ToString());
            Ea.Costo = int.Parse(dtgMostrar.Rows[fila].Cells[3].Value.ToString());
            Ea.Cantidadxpar = int.Parse(dtgMostrar.Rows[fila].Cells[4].Value.ToString());
            switch (columna)
            {
                case 5:
                    {
                        FrmAddCompraInsumos frmAddCompraInsumos = new FrmAddCompraInsumos();
                        frmAddCompraInsumos.ShowDialog();
                    } break;
                case 6: { Mai.Borrar(Ea.Id); } break;
                default:
                    break;  
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mai.Mostrar(dtgMostrar,TxtBuscar.Text);
        }

        
    }
}
