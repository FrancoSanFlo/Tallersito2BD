
namespace Taller2_BD
{
    partial class IngresarVenta
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
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_agregarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombreProducto = new System.Windows.Forms.TextBox();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.textBox_codigoVenta = new System.Windows.Forms.TextBox();
            this.comboBox_codigoProducto = new System.Windows.Forms.ComboBox();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.button_ingresarVenta = new System.Windows.Forms.Button();
            this.checkBox_ordenCompleta = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(706, 340);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(65, 28);
            this.button_volver.TabIndex = 0;
            this.button_volver.Text = "VOLVER";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_ordenCompleta);
            this.groupBox1.Controls.Add(this.button_ingresarVenta);
            this.groupBox1.Controls.Add(this.button_agregarProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_nombreProducto);
            this.groupBox1.Controls.Add(this.textBox_cantidad);
            this.groupBox1.Controls.Add(this.textBox_codigoVenta);
            this.groupBox1.Controls.Add(this.comboBox_codigoProducto);
            this.groupBox1.Controls.Add(this.comboBox_cliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar nueva venta";
            // 
            // button_agregarProducto
            // 
            this.button_agregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregarProducto.Location = new System.Drawing.Point(450, 168);
            this.button_agregarProducto.Name = "button_agregarProducto";
            this.button_agregarProducto.Size = new System.Drawing.Size(96, 48);
            this.button_agregarProducto.TabIndex = 11;
            this.button_agregarProducto.Text = "Agregar producto";
            this.button_agregarProducto.UseVisualStyleBackColor = true;
            this.button_agregarProducto.Click += new System.EventHandler(this.button_agregarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código venta";
            // 
            // textBox_nombreProducto
            // 
            this.textBox_nombreProducto.Location = new System.Drawing.Point(450, 90);
            this.textBox_nombreProducto.Name = "textBox_nombreProducto";
            this.textBox_nombreProducto.Size = new System.Drawing.Size(127, 22);
            this.textBox_nombreProducto.TabIndex = 5;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(616, 92);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(127, 22);
            this.textBox_cantidad.TabIndex = 4;
            // 
            // textBox_codigoVenta
            // 
            this.textBox_codigoVenta.Location = new System.Drawing.Point(28, 92);
            this.textBox_codigoVenta.Name = "textBox_codigoVenta";
            this.textBox_codigoVenta.Size = new System.Drawing.Size(127, 22);
            this.textBox_codigoVenta.TabIndex = 3;
            // 
            // comboBox_codigoProducto
            // 
            this.comboBox_codigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_codigoProducto.FormattingEnabled = true;
            this.comboBox_codigoProducto.Location = new System.Drawing.Point(275, 90);
            this.comboBox_codigoProducto.Name = "comboBox_codigoProducto";
            this.comboBox_codigoProducto.Size = new System.Drawing.Size(127, 21);
            this.comboBox_codigoProducto.TabIndex = 2;
            this.comboBox_codigoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox_codigoProducto_SelectedIndexChanged);
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(28, 195);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(127, 21);
            this.comboBox_cliente.TabIndex = 0;
            // 
            // button_ingresarVenta
            // 
            this.button_ingresarVenta.Location = new System.Drawing.Point(647, 243);
            this.button_ingresarVenta.Name = "button_ingresarVenta";
            this.button_ingresarVenta.Size = new System.Drawing.Size(96, 48);
            this.button_ingresarVenta.TabIndex = 12;
            this.button_ingresarVenta.Text = "Ingresar venta";
            this.button_ingresarVenta.UseVisualStyleBackColor = true;
            this.button_ingresarVenta.Click += new System.EventHandler(this.button_ingresarVenta_Click);
            // 
            // checkBox_ordenCompleta
            // 
            this.checkBox_ordenCompleta.AutoSize = true;
            this.checkBox_ordenCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ordenCompleta.Location = new System.Drawing.Point(587, 187);
            this.checkBox_ordenCompleta.Name = "checkBox_ordenCompleta";
            this.checkBox_ordenCompleta.Size = new System.Drawing.Size(166, 17);
            this.checkBox_ordenCompleta.TabIndex = 13;
            this.checkBox_ordenCompleta.Text = "Orden de productos completa";
            this.checkBox_ordenCompleta.UseVisualStyleBackColor = true;
            // 
            // IngresarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_volver);
            this.Name = "IngresarVenta";
            this.Text = "IngresarVenta";
            this.Load += new System.EventHandler(this.IngresarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_agregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombreProducto;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.TextBox textBox_codigoVenta;
        private System.Windows.Forms.ComboBox comboBox_codigoProducto;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Button button_ingresarVenta;
        private System.Windows.Forms.CheckBox checkBox_ordenCompleta;
    }
}