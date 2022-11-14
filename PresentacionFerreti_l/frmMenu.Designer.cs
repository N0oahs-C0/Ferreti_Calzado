
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPedidos = new System.Windows.Forms.ToolStripButton();
            this.TsbVentas = new System.Windows.Forms.ToolStripButton();
            this.TsbAlmacenInsumos = new System.Windows.Forms.ToolStripButton();
            this.tsbCompraInsumos = new System.Windows.Forms.ToolStripButton();
            this.tsbProductost = new System.Windows.Forms.ToolStripButton();
            this.TsbProductA = new System.Windows.Forms.ToolStripButton();
            this.TspSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPedidos,
            this.TsbVentas,
            this.TsbAlmacenInsumos,
            this.tsbCompraInsumos,
            this.tsbProductost,
            this.TsbProductA,
            this.TspSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 42);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPedidos
            // 
            this.tsbPedidos.AutoSize = false;
            this.tsbPedidos.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.pedidos;
            this.tsbPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPedidos.Name = "tsbPedidos";
            this.tsbPedidos.Size = new System.Drawing.Size(40, 40);
            this.tsbPedidos.Text = "Pedidos";
            this.tsbPedidos.Click += new System.EventHandler(this.tsbPedidos_Click);
            // 
            // TsbVentas
            // 
            this.TsbVentas.AutoSize = false;
            this.TsbVentas.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.producto;
            this.TsbVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TsbVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbVentas.Name = "TsbVentas";
            this.TsbVentas.Size = new System.Drawing.Size(40, 40);
            this.TsbVentas.Text = "Ventas";
            this.TsbVentas.Click += new System.EventHandler(this.TsbVentas_Click);
            // 
            // TsbAlmacenInsumos
            // 
            this.TsbAlmacenInsumos.AutoSize = false;
            this.TsbAlmacenInsumos.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.almacen;
            this.TsbAlmacenInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TsbAlmacenInsumos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAlmacenInsumos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAlmacenInsumos.Name = "TsbAlmacenInsumos";
            this.TsbAlmacenInsumos.Size = new System.Drawing.Size(40, 40);
            this.TsbAlmacenInsumos.Text = "Almacen Insumos";
            this.TsbAlmacenInsumos.Click += new System.EventHandler(this.TsbAlmacenInsumos_Click);
            // 
            // tsbCompraInsumos
            // 
            this.tsbCompraInsumos.AutoSize = false;
            this.tsbCompraInsumos.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.bolsa_de_la_compra;
            this.tsbCompraInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCompraInsumos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCompraInsumos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCompraInsumos.Name = "tsbCompraInsumos";
            this.tsbCompraInsumos.Size = new System.Drawing.Size(40, 40);
            this.tsbCompraInsumos.Text = "Compra de Insumos";
            this.tsbCompraInsumos.Click += new System.EventHandler(this.tsbCompraInsumos_Click);
            // 
            // tsbProductost
            // 
            this.tsbProductost.AutoSize = false;
            this.tsbProductost.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.producto_terminado;
            this.tsbProductost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbProductost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProductost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductost.Name = "tsbProductost";
            this.tsbProductost.Size = new System.Drawing.Size(40, 40);
            this.tsbProductost.Text = "Productos Terminados";
            this.tsbProductost.Click += new System.EventHandler(this.tsbProductost_Click);
            // 
            // TsbProductA
            // 
            this.TsbProductA.AutoSize = false;
            this.TsbProductA.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.caja;
            this.TsbProductA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TsbProductA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbProductA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbProductA.Name = "TsbProductA";
            this.TsbProductA.Size = new System.Drawing.Size(40, 40);
            this.TsbProductA.Text = "ProductoApartado";
            this.TsbProductA.Click += new System.EventHandler(this.TsbProductA_Click);
            // 
            // TspSalir
            // 
            this.TspSalir.AutoSize = false;
            this.TspSalir.BackgroundImage = global::PresentacionFerreti_l.Properties.Resources.cerrar;
            this.TspSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TspSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TspSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspSalir.Name = "TspSalir";
            this.TspSalir.Size = new System.Drawing.Size(40, 40);
            this.TspSalir.Text = "Salir";
            this.TspSalir.Click += new System.EventHandler(this.TspSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 550);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPedidos;
        private System.Windows.Forms.ToolStripButton TsbVentas;
        private System.Windows.Forms.ToolStripButton TsbAlmacenInsumos;
        private System.Windows.Forms.ToolStripButton tsbCompraInsumos;
        private System.Windows.Forms.ToolStripButton tsbProductost;
        private System.Windows.Forms.ToolStripButton TsbProductA;
        private System.Windows.Forms.ToolStripButton TspSalir;
    }
}