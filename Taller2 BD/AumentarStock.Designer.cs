
namespace Taller2_BD
{
    partial class AumentarStock
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
            this.comboBox_nomProdAumento = new System.Windows.Forms.ComboBox();
            this.textBox_stockIngresado = new System.Windows.Forms.TextBox();
            this.datoStock = new System.Windows.Forms.DataGridView();
            this.button_resfrescarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_stockActual = new System.Windows.Forms.TextBox();
            this.checkBox_confirmarNombre = new System.Windows.Forms.CheckBox();
            this.button_ingresoStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_nomProdAumento
            // 
            this.comboBox_nomProdAumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nomProdAumento.FormattingEnabled = true;
            this.comboBox_nomProdAumento.Location = new System.Drawing.Point(50, 66);
            this.comboBox_nomProdAumento.Name = "comboBox_nomProdAumento";
            this.comboBox_nomProdAumento.Size = new System.Drawing.Size(156, 21);
            this.comboBox_nomProdAumento.TabIndex = 0;
            this.comboBox_nomProdAumento.DropDown += new System.EventHandler(this.comboBox_nomProdAumento_DropDown);
            // 
            // textBox_stockIngresado
            // 
            this.textBox_stockIngresado.Location = new System.Drawing.Point(50, 229);
            this.textBox_stockIngresado.Name = "textBox_stockIngresado";
            this.textBox_stockIngresado.Size = new System.Drawing.Size(156, 20);
            this.textBox_stockIngresado.TabIndex = 1;
            // 
            // datoStock
            // 
            this.datoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datoStock.Location = new System.Drawing.Point(466, 66);
            this.datoStock.Name = "datoStock";
            this.datoStock.Size = new System.Drawing.Size(322, 181);
            this.datoStock.TabIndex = 3;
            this.datoStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_resfrescarDatos
            // 
            this.button_resfrescarDatos.Location = new System.Drawing.Point(466, 269);
            this.button_resfrescarDatos.Name = "button_resfrescarDatos";
            this.button_resfrescarDatos.Size = new System.Drawing.Size(133, 23);
            this.button_resfrescarDatos.TabIndex = 4;
            this.button_resfrescarDatos.Text = "Refrescar datos";
            this.button_resfrescarDatos.UseVisualStyleBackColor = true;
            this.button_resfrescarDatos.Click += new System.EventHandler(this.button_resfrescarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de stock a agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock de todos los productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock actual";
            // 
            // textBox_stockActual
            // 
            this.textBox_stockActual.Location = new System.Drawing.Point(50, 146);
            this.textBox_stockActual.Name = "textBox_stockActual";
            this.textBox_stockActual.Size = new System.Drawing.Size(156, 20);
            this.textBox_stockActual.TabIndex = 10;
            // 
            // checkBox_confirmarNombre
            // 
            this.checkBox_confirmarNombre.AutoSize = true;
            this.checkBox_confirmarNombre.Location = new System.Drawing.Point(232, 70);
            this.checkBox_confirmarNombre.Name = "checkBox_confirmarNombre";
            this.checkBox_confirmarNombre.Size = new System.Drawing.Size(115, 17);
            this.checkBox_confirmarNombre.TabIndex = 11;
            this.checkBox_confirmarNombre.Text = "Confirmar producto";
            this.checkBox_confirmarNombre.UseVisualStyleBackColor = true;
            this.checkBox_confirmarNombre.CheckedChanged += new System.EventHandler(this.checkBox_confirmarNombre_CheckedChanged);
            // 
            // button_ingresoStock
            // 
            this.button_ingresoStock.Location = new System.Drawing.Point(50, 287);
            this.button_ingresoStock.Name = "button_ingresoStock";
            this.button_ingresoStock.Size = new System.Drawing.Size(96, 40);
            this.button_ingresoStock.TabIndex = 12;
            this.button_ingresoStock.Text = "Actualizar Precio";
            this.button_ingresoStock.UseVisualStyleBackColor = true;
            this.button_ingresoStock.Click += new System.EventHandler(this.button_ingresoStock_Click);
            // 
            // AumentarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ingresoStock);
            this.Controls.Add(this.checkBox_confirmarNombre);
            this.Controls.Add(this.textBox_stockActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_resfrescarDatos);
            this.Controls.Add(this.datoStock);
            this.Controls.Add(this.textBox_stockIngresado);
            this.Controls.Add(this.comboBox_nomProdAumento);
            this.Name = "AumentarStock";
            this.Text = "AumentarStock";
            ((System.ComponentModel.ISupportInitialize)(this.datoStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_nomProdAumento;
        private System.Windows.Forms.TextBox textBox_stockIngresado;
        private System.Windows.Forms.DataGridView datoStock;
        private System.Windows.Forms.Button button_resfrescarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_stockActual;
        private System.Windows.Forms.CheckBox checkBox_confirmarNombre;
        private System.Windows.Forms.Button button_ingresoStock;
    }
}