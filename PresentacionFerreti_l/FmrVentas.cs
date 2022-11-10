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

        }

        private void dgtVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Actualizar()
        {
            mv.Mostrar(dgtVentas, txtBuscar.Text);
        }
    }
}
