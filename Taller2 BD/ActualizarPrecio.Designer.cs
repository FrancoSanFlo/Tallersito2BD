
namespace Taller2_BD
{
    partial class ActualizarPrecio
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
            this.comboBox_actualizarPrecio = new System.Windows.Forms.ComboBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.button_actualizarPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_actualizarPrecio
            // 
            this.comboBox_actualizarPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_actualizarPrecio.FormattingEnabled = true;
            this.comboBox_actualizarPrecio.Location = new System.Drawing.Point(68, 99);
            this.comboBox_actualizarPrecio.Name = "comboBox_actualizarPrecio";
            this.comboBox_actualizarPrecio.Size = new System.Drawing.Size(186, 21);
            this.comboBox_actualizarPrecio.TabIndex = 0;
            this.comboBox_actualizarPrecio.DropDown += new System.EventHandler(this.comboBox_actualizarPrecio_DropDown);
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(68, 165);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(186, 20);
            this.textBox_precio.TabIndex = 1;
            // 
            // button_actualizarPrecio
            // 
            this.button_actualizarPrecio.Location = new System.Drawing.Point(68, 240);
            this.button_actualizarPrecio.Name = "button_actualizarPrecio";
            this.button_actualizarPrecio.Size = new System.Drawing.Size(93, 45);
            this.button_actualizarPrecio.TabIndex = 2;
            this.button_actualizarPrecio.Text = "Actualizar precio";
            this.button_actualizarPrecio.UseVisualStyleBackColor = true;
            this.button_actualizarPrecio.Click += new System.EventHandler(this.button_actualizarPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar precio";
            // 
            // ActualizarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_actualizarPrecio);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.comboBox_actualizarPrecio);
            this.Name = "ActualizarPrecio";
            this.Text = "ActualizarPrecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_actualizarPrecio;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Button button_actualizarPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}