
namespace Taller2_BD
{
    partial class DetalleVenta
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
            this.dateTimePicker_fechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_consultarVenta = new System.Windows.Forms.Button();
            this.dataGridView_ventaConsultada = new System.Windows.Forms.DataGridView();
            this.textBox_nombreCliente = new System.Windows.Forms.TextBox();
            this.comboBox_codigoCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventaConsultada)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(694, 391);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(94, 41);
            this.button_volver.TabIndex = 0;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_fechaVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_consultarVenta);
            this.groupBox1.Controls.Add(this.dataGridView_ventaConsultada);
            this.groupBox1.Controls.Add(this.textBox_nombreCliente);
            this.groupBox1.Controls.Add(this.comboBox_codigoCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar venta";
            // 
            // dateTimePicker_fechaVenta
            // 
            this.dateTimePicker_fechaVenta.Location = new System.Drawing.Point(31, 108);
            this.dateTimePicker_fechaVenta.Name = "dateTimePicker_fechaVenta";
            this.dateTimePicker_fechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaVenta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // button_consultarVenta
            // 
            this.button_consultarVenta.Location = new System.Drawing.Point(31, 300);
            this.button_consultarVenta.Name = "button_consultarVenta";
            this.button_consultarVenta.Size = new System.Drawing.Size(89, 46);
            this.button_consultarVenta.TabIndex = 5;
            this.button_consultarVenta.Text = "Realizar búsqueda";
            this.button_consultarVenta.UseVisualStyleBackColor = true;
            this.button_consultarVenta.Click += new System.EventHandler(this.button_consultarVenta_Click);
            // 
            // dataGridView_ventaConsultada
            // 
            this.dataGridView_ventaConsultada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ventaConsultada.Location = new System.Drawing.Point(247, 19);
            this.dataGridView_ventaConsultada.Name = "dataGridView_ventaConsultada";
            this.dataGridView_ventaConsultada.Size = new System.Drawing.Size(512, 337);
            this.dataGridView_ventaConsultada.TabIndex = 4;
            // 
            // textBox_nombreCliente
            // 
            this.textBox_nombreCliente.Location = new System.Drawing.Point(31, 162);
            this.textBox_nombreCliente.Name = "textBox_nombreCliente";
            this.textBox_nombreCliente.Size = new System.Drawing.Size(151, 20);
            this.textBox_nombreCliente.TabIndex = 3;
            // 
            // comboBox_codigoCliente
            // 
            this.comboBox_codigoCliente.FormattingEnabled = true;
            this.comboBox_codigoCliente.Location = new System.Drawing.Point(31, 226);
            this.comboBox_codigoCliente.Name = "comboBox_codigoCliente";
            this.comboBox_codigoCliente.Size = new System.Drawing.Size(89, 21);
            this.comboBox_codigoCliente.TabIndex = 2;
            this.comboBox_codigoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_codigoCliente_SelectedIndexChanged);
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_volver);
            this.Name = "DetalleVenta";
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventaConsultada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_consultarVenta;
        private System.Windows.Forms.DataGridView dataGridView_ventaConsultada;
        private System.Windows.Forms.TextBox textBox_nombreCliente;
        private System.Windows.Forms.ComboBox comboBox_codigoCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaVenta;
    }
}