
namespace Taller2_BD
{
    partial class FuncionesAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actualizarPrecio = new System.Windows.Forms.Button();
            this.eliminarProducto = new System.Windows.Forms.Button();
            this.ingresoProducto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.actualizarCiudad = new System.Windows.Forms.Button();
            this.eliminarCliente = new System.Windows.Forms.Button();
            this.ingresarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actualizarPrecio);
            this.groupBox1.Controls.Add(this.eliminarProducto);
            this.groupBox1.Controls.Add(this.ingresoProducto);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // actualizarPrecio
            // 
            this.actualizarPrecio.Location = new System.Drawing.Point(316, 41);
            this.actualizarPrecio.Name = "actualizarPrecio";
            this.actualizarPrecio.Size = new System.Drawing.Size(103, 58);
            this.actualizarPrecio.TabIndex = 6;
            this.actualizarPrecio.Text = "Actualizar precio";
            this.actualizarPrecio.UseVisualStyleBackColor = true;
            this.actualizarPrecio.Click += new System.EventHandler(this.actualizarPrecio_Click);
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.Location = new System.Drawing.Point(163, 41);
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.Size = new System.Drawing.Size(103, 58);
            this.eliminarProducto.TabIndex = 5;
            this.eliminarProducto.Text = "Eliminar Producto";
            this.eliminarProducto.UseVisualStyleBackColor = true;
            this.eliminarProducto.Click += new System.EventHandler(this.eliminarProducto_Click);
            // 
            // ingresoProducto
            // 
            this.ingresoProducto.Location = new System.Drawing.Point(15, 41);
            this.ingresoProducto.Name = "ingresoProducto";
            this.ingresoProducto.Size = new System.Drawing.Size(103, 58);
            this.ingresoProducto.TabIndex = 0;
            this.ingresoProducto.Text = "Ingresar Producto";
            this.ingresoProducto.UseVisualStyleBackColor = true;
            this.ingresoProducto.Click += new System.EventHandler(this.ingresoProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.actualizarCiudad);
            this.groupBox2.Controls.Add(this.eliminarCliente);
            this.groupBox2.Controls.Add(this.ingresarCliente);
            this.groupBox2.Location = new System.Drawing.Point(26, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // actualizarCiudad
            // 
            this.actualizarCiudad.Location = new System.Drawing.Point(316, 46);
            this.actualizarCiudad.Name = "actualizarCiudad";
            this.actualizarCiudad.Size = new System.Drawing.Size(103, 58);
            this.actualizarCiudad.TabIndex = 9;
            this.actualizarCiudad.Text = "Actualizar ciudad cliente extranjero";
            this.actualizarCiudad.UseVisualStyleBackColor = true;
            this.actualizarCiudad.Click += new System.EventHandler(this.actualizarCiudad_Click);
            // 
            // eliminarCliente
            // 
            this.eliminarCliente.Location = new System.Drawing.Point(163, 46);
            this.eliminarCliente.Name = "eliminarCliente";
            this.eliminarCliente.Size = new System.Drawing.Size(103, 58);
            this.eliminarCliente.TabIndex = 8;
            this.eliminarCliente.Text = "Eliminar cliente";
            this.eliminarCliente.UseVisualStyleBackColor = true;
            this.eliminarCliente.Click += new System.EventHandler(this.eliminarCliente_Click);
            // 
            // ingresarCliente
            // 
            this.ingresarCliente.Location = new System.Drawing.Point(15, 46);
            this.ingresarCliente.Name = "ingresarCliente";
            this.ingresarCliente.Size = new System.Drawing.Size(103, 58);
            this.ingresarCliente.TabIndex = 7;
            this.ingresarCliente.Text = "Ingresar  cliente";
            this.ingresarCliente.UseVisualStyleBackColor = true;
            this.ingresarCliente.Click += new System.EventHandler(this.ingresarCliente_Click);
            // 
            // FuncionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FuncionesAdmin";
            this.Text = "FuncionesAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ingresoProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button actualizarPrecio;
        private System.Windows.Forms.Button eliminarProducto;
        private System.Windows.Forms.Button actualizarCiudad;
        private System.Windows.Forms.Button eliminarCliente;
        private System.Windows.Forms.Button ingresarCliente;
    }
}