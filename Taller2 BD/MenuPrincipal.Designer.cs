
namespace Taller2_BD
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.verDatos = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ingresoSitio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_aumentoStock = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Administrador = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_detalleVenta = new System.Windows.Forms.Button();
            this.button_nuevaVenta = new System.Windows.Forms.Button();
            this.button_historicoInterna = new System.Windows.Forms.Button();
            this.button_historicosNacionales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // verDatos
            // 
            this.verDatos.Location = new System.Drawing.Point(713, 415);
            this.verDatos.Name = "verDatos";
            this.verDatos.Size = new System.Drawing.Size(75, 23);
            this.verDatos.TabIndex = 0;
            this.verDatos.Text = "Ver Datos";
            this.verDatos.UseVisualStyleBackColor = true;
            this.verDatos.Click += new System.EventHandler(this.verDatos_Click);
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(588, 330);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(200, 78);
            this.datos.TabIndex = 1;
            this.datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ingresoSitio);
            this.groupBox1.Location = new System.Drawing.Point(588, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso de enlistado";
            // 
            // button_ingresoSitio
            // 
            this.button_ingresoSitio.Location = new System.Drawing.Point(34, 35);
            this.button_ingresoSitio.Name = "button_ingresoSitio";
            this.button_ingresoSitio.Size = new System.Drawing.Size(130, 44);
            this.button_ingresoSitio.TabIndex = 0;
            this.button_ingresoSitio.Text = "Ingresar al sitio";
            this.button_ingresoSitio.UseVisualStyleBackColor = true;
            this.button_ingresoSitio.Click += new System.EventHandler(this.button_ingresoSitio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_aumentoStock);
            this.groupBox2.Location = new System.Drawing.Point(588, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de productos";
            // 
            // button_aumentoStock
            // 
            this.button_aumentoStock.Location = new System.Drawing.Point(34, 35);
            this.button_aumentoStock.Name = "button_aumentoStock";
            this.button_aumentoStock.Size = new System.Drawing.Size(130, 44);
            this.button_aumentoStock.TabIndex = 0;
            this.button_aumentoStock.Text = "Aumento de stock";
            this.button_aumentoStock.UseVisualStyleBackColor = true;
            this.button_aumentoStock.Click += new System.EventHandler(this.button_aumentoStock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Administrador);
            this.groupBox3.Location = new System.Drawing.Point(588, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funciones de administrador";
            // 
            // button_Administrador
            // 
            this.button_Administrador.Location = new System.Drawing.Point(34, 35);
            this.button_Administrador.Name = "button_Administrador";
            this.button_Administrador.Size = new System.Drawing.Size(130, 44);
            this.button_Administrador.TabIndex = 0;
            this.button_Administrador.Text = "Administrador";
            this.button_Administrador.UseVisualStyleBackColor = true;
            this.button_Administrador.Click += new System.EventHandler(this.button_Administrador_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_detalleVenta);
            this.groupBox4.Controls.Add(this.button_nuevaVenta);
            this.groupBox4.Controls.Add(this.button_historicoInterna);
            this.groupBox4.Controls.Add(this.button_historicosNacionales);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 426);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // button_detalleVenta
            // 
            this.button_detalleVenta.Location = new System.Drawing.Point(127, 56);
            this.button_detalleVenta.Name = "button_detalleVenta";
            this.button_detalleVenta.Size = new System.Drawing.Size(94, 44);
            this.button_detalleVenta.TabIndex = 3;
            this.button_detalleVenta.Text = "Detalle de venta";
            this.button_detalleVenta.UseVisualStyleBackColor = true;
            this.button_detalleVenta.Click += new System.EventHandler(this.button_detalleVenta_Click);
            // 
            // button_nuevaVenta
            // 
            this.button_nuevaVenta.Location = new System.Drawing.Point(15, 56);
            this.button_nuevaVenta.Name = "button_nuevaVenta";
            this.button_nuevaVenta.Size = new System.Drawing.Size(94, 44);
            this.button_nuevaVenta.TabIndex = 2;
            this.button_nuevaVenta.Text = "Ingresar nueva venta";
            this.button_nuevaVenta.UseVisualStyleBackColor = true;
            this.button_nuevaVenta.Click += new System.EventHandler(this.button_nuevaVenta_Click);
            // 
            // button_historicoInterna
            // 
            this.button_historicoInterna.Location = new System.Drawing.Point(127, 152);
            this.button_historicoInterna.Name = "button_historicoInterna";
            this.button_historicoInterna.Size = new System.Drawing.Size(94, 44);
            this.button_historicoInterna.TabIndex = 1;
            this.button_historicoInterna.Text = "Históricos internacionales";
            this.button_historicoInterna.UseVisualStyleBackColor = true;
            // 
            // button_historicosNacionales
            // 
            this.button_historicosNacionales.Location = new System.Drawing.Point(15, 152);
            this.button_historicosNacionales.Name = "button_historicosNacionales";
            this.button_historicosNacionales.Size = new System.Drawing.Size(94, 44);
            this.button_historicosNacionales.TabIndex = 0;
            this.button_historicosNacionales.Text = "Históricos nacionales";
            this.button_historicosNacionales.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.verDatos);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verDatos;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Administrador;
        private System.Windows.Forms.Button button_ingresoSitio;
        private System.Windows.Forms.Button button_aumentoStock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_historicosNacionales;
        private System.Windows.Forms.Button button_historicoInterna;
        private System.Windows.Forms.Button button_nuevaVenta;
        private System.Windows.Forms.Button button_detalleVenta;
    }
}

