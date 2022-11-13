
namespace PresentacionFerreti_l
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnAlmacenInsumos = new System.Windows.Forms.Button();
            this.btnCompraInsumos = new System.Windows.Forms.Button();
            this.btnProductosTerminados = new System.Windows.Forms.Button();
            this.btnProductosApartados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(184, 71);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(321, 71);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAlmacenInsumos
            // 
            this.btnAlmacenInsumos.Location = new System.Drawing.Point(464, 71);
            this.btnAlmacenInsumos.Name = "btnAlmacenInsumos";
            this.btnAlmacenInsumos.Size = new System.Drawing.Size(132, 23);
            this.btnAlmacenInsumos.TabIndex = 2;
            this.btnAlmacenInsumos.Text = "Almacen de insumos";
            this.btnAlmacenInsumos.UseVisualStyleBackColor = true;
            this.btnAlmacenInsumos.Click += new System.EventHandler(this.btnAlmacenInsumos_Click);
            // 
            // btnCompraInsumos
            // 
            this.btnCompraInsumos.Location = new System.Drawing.Point(184, 150);
            this.btnCompraInsumos.Name = "btnCompraInsumos";
            this.btnCompraInsumos.Size = new System.Drawing.Size(118, 23);
            this.btnCompraInsumos.TabIndex = 3;
            this.btnCompraInsumos.Text = "Compra de insumos";
            this.btnCompraInsumos.UseVisualStyleBackColor = true;
            this.btnCompraInsumos.Click += new System.EventHandler(this.btnCompraInsumos_Click);
            // 
            // btnProductosTerminados
            // 
            this.btnProductosTerminados.Location = new System.Drawing.Point(345, 150);
            this.btnProductosTerminados.Name = "btnProductosTerminados";
            this.btnProductosTerminados.Size = new System.Drawing.Size(142, 23);
            this.btnProductosTerminados.TabIndex = 4;
            this.btnProductosTerminados.Text = "Productos terminados";
            this.btnProductosTerminados.UseVisualStyleBackColor = true;
            this.btnProductosTerminados.Click += new System.EventHandler(this.btnProductosTerminados_Click);
            // 
            // btnProductosApartados
            // 
            this.btnProductosApartados.Location = new System.Drawing.Point(532, 150);
            this.btnProductosApartados.Name = "btnProductosApartados";
            this.btnProductosApartados.Size = new System.Drawing.Size(141, 23);
            this.btnProductosApartados.TabIndex = 5;
            this.btnProductosApartados.Text = "Produtos apartados";
            this.btnProductosApartados.UseVisualStyleBackColor = true;
            this.btnProductosApartados.Click += new System.EventHandler(this.btnProductosApartados_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProductosApartados);
            this.Controls.Add(this.btnProductosTerminados);
            this.Controls.Add(this.btnCompraInsumos);
            this.Controls.Add(this.btnAlmacenInsumos);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnPedidos);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAlmacenInsumos;
        private System.Windows.Forms.Button btnCompraInsumos;
        private System.Windows.Forms.Button btnProductosTerminados;
        private System.Windows.Forms.Button btnProductosApartados;
    }
}