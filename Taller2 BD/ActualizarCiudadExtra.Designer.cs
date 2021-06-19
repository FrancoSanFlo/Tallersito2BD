
namespace Taller2_BD
{
    partial class ActualizarCiudadExtra
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
            this.button_actualizar = new System.Windows.Forms.Button();
            this.comboBox_ciudades = new System.Windows.Forms.ComboBox();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(54, 326);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(98, 48);
            this.button_actualizar.TabIndex = 0;
            this.button_actualizar.Text = "Actualizar Ciudad";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // comboBox_ciudades
            // 
            this.comboBox_ciudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ciudades.FormattingEnabled = true;
            this.comboBox_ciudades.Location = new System.Drawing.Point(54, 119);
            this.comboBox_ciudades.Name = "comboBox_ciudades";
            this.comboBox_ciudades.Size = new System.Drawing.Size(167, 21);
            this.comboBox_ciudades.TabIndex = 1;
            this.comboBox_ciudades.DropDown += new System.EventHandler(this.comboBox_ciudades_DropDown);
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Location = new System.Drawing.Point(54, 209);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(167, 20);
            this.textBox_ciudad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciudades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar nueva ciudad";
            // 
            // ActualizarCiudadExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ciudad);
            this.Controls.Add(this.comboBox_ciudades);
            this.Controls.Add(this.button_actualizar);
            this.Name = "ActualizarCiudadExtra";
            this.Text = "ActualizarCiudadExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.ComboBox comboBox_ciudades;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}